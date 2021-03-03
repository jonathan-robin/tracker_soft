using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace track3r
{
    public partial class sessionLangage : Form
    {
        Stopwatch watch = new Stopwatch();
        public bool play = true;
        public int idLangage;
        public bool saveSession = false;
        public static string probleme, lien, source, description;
        public string startingDay, startingTime, nomLangage, f4duration;
        public string connectionString = "server=localhost;database=tracker;uid=root;";
        object[] pause = new object[6];
        public sessionLangage()
        {
            InitializeComponent();
        }
        private void sessionLangage_Load(object sender, EventArgs e)
        {
            Name = "LANGAGE > " + nomLangage;
            lblNomDuProjet.Text = nomLangage;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            watch.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan time = watch.Elapsed;
            txtTimer.Text = string.Format("{0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);
        }
        public void saveSessionLangage()
        {
            using (SAVELANGAGE F3 = new SAVELANGAGE())
            {
                if (F3.ShowDialog() == DialogResult.OK)
                {
                    F3.nomLangage = nomLangage;
                    source = F3.source;
                    description = F3.description;
                    probleme = F3.probleme;
                    lien = F3.lien;
                }
                saveSession = true;
            }
        }
        public string requeteSQL(string startingDay, string startingTime, DateTime endingTime, string duration, string drapeau,
      string source, string lien, string description, string probleme, int idLangage)
        {
            if (drapeau is null)
            {
                return "INSERT INTO langage_session (startingDay, startingTime, endingTime, duration, source, probleme, lien, description, idLangage) VALUES " +
                "('" + startingDay + "','" + startingTime + "','" + endingTime + "','" + duration + "','" + source + "','" + probleme + 
                "','" + lien + "','" + description + "','" + idLangage + "')";
            }
            return "INSERT INTO pause(startingTime, endingTime, duration, drapeau, idDrapeau) VALUES " +
                "('"+ startingTime + "','" + endingTime + "','" + duration +"','langage','" + idLangage
              + "')";
        }
        public void sendRequeteSQL(string requeteSQL)
        {
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(requeteSQL, cnn);
            try
            {
                cnn.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {            
            if (play == true)
            {
                timer1.Stop();
                watch.Reset();
                while (saveSession == false)
                {
                    saveSessionLangage();
                }
                saveSession = false;
                DateTime end = DateTime.Now;
                string duration = txtTimer.Text;
                string requete = requeteSQL(startingDay, startingTime, end, duration, null, source, probleme, lien, description, idLangage);
                sendRequeteSQL(requete);
                btnStop.Enabled = false;
                btnReset.Enabled = false;
                btnPause.BackgroundImage = Properties.Resources.playBackgroundImage;
                pause[0] = DateTime.Now;
                pause[1] = DateTime.Now;
                pause[5] = nomLangage;
                play = !play;
                MessageBox.Show("Session mise en pause !");
                probleme = "";
                lien = "";
                source = "";
                description = "";
            }
            else
            {
                btnStop.Enabled = true;
                btnReset.Enabled = true;
                timer1.Start();
                watch.Start();
                btnPause.BackgroundImage = Properties.Resources.pause11;
                pause[4] = nomLangage;
                pause[2] = DateTime.Now;
                startingTime = Convert.ToString(pause[2]).Split(' ')[1];
                TimeSpan diff = Convert.ToDateTime(pause[2]) - Convert.ToDateTime(pause[1]);
                DateTime dif = Convert.ToDateTime(string.Format("{0:00}:{1:00}:{2:00}", diff.Hours, diff.Minutes, diff.Seconds));
                string[] di = dif.ToString().Split(' ');
                pause[3] = di[1];
                string requete = requeteSQL(Convert.ToString(pause[0]), Convert.ToString(pause[1]), Convert.ToDateTime(pause[2]), Convert.ToString(pause[3]), Convert.ToString(pause[4])
                    , Convert.ToString(pause[5]), null, null, null, idLangage);
                sendRequeteSQL(requete);
                play = !play;
            }
        }
        public void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            watch.Stop();
            while (saveSession == false)
            {
                saveSessionLangage();
            }
            saveSession = false;
            string duration = txtTimer.Text;
            if (f4duration != null)
            {
                duration = f4duration;
            }
            DateTime end = DateTime.Now;
            string requete = requeteSQL(startingDay, startingTime, end, duration, null, source, probleme, lien, description, idLangage);
            sendRequeteSQL(requete);
            sessionLangage.ActiveForm.Close();
            probleme = lien = source = description = "test";
            LANGAGE f2 = new LANGAGE();
            f2.Show();

        }
        public void btnRetour_Click(object sender, EventArgs e)
        {
            LEAVELANGAGE f4 = new LEAVELANGAGE();
            f4.startingDay = startingDay;
            f4.startingTime = startingTime;
            f4.nomLangage = nomLangage;
            f4.duration = txtTimer.Text;
            f4.idLangage = idLangage;
            f4.Show();
        }
    }
}
