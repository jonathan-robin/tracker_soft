using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace track3r
{
    public partial class INGAME : Form
    {
        public string startingDay;
        public string startingTime;
        public string connectionString = "server=localhost;database=tracker;uid=root;";
        public string flag;
        public string f4duration;
        object[] pause = new object[6];
        Stopwatch watch = new Stopwatch();
        bool play = true;
        public int idJeux;
        public INGAME()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            Text = "INGAME > " + flag;
            switch (flag)
            {
                case "aoe":  
                    btnImage.BackgroundImage = Properties.Resources.AoE_Definitive_Edition;
                    break;
                case "tbc":
                    btnImage.BackgroundImage = Properties.Resources.tbcimage;
                    break;
                case "shadowlands":
                    btnImage.BackgroundImage = Properties.Resources.shadowlands;
                    break;
                case "hs":
                    btnImage.BackgroundImage = Properties.Resources.hs;
                    break;
            }
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
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (play == true)
            {
                timer1.Stop();
                watch.Reset();
                btnPause.BackgroundImage = Properties.Resources.playBackgroundImage;
                string duration = txtTimer.Text;
                pause[0] = DateTime.Now;
                pause[1] = DateTime.Now;
                pause[5] = flag;
                play = !play;
                MessageBox.Show("Session mise en pause !");
                string requete = requeteSQL(startingDay, startingTime, Convert.ToDateTime(pause[0]), duration, null, idJeux);
                sendRequeteSQL(requete);
                
            }
            else
            {
                timer1.Start();
                watch.Start();
                btnPause.BackgroundImage = Properties.Resources.pause11;
                pause[2] = DateTime.Now;
                startingTime = Convert.ToString(pause[2]).Split(' ')[1];
                TimeSpan diff = Convert.ToDateTime(pause[2]) - Convert.ToDateTime(pause[1]);
                DateTime dif = Convert.ToDateTime(string.Format("{0:00}:{1:00}:{2:00}", diff.Hours, diff.Minutes, diff.Seconds));
                string[] di = dif.ToString().Split(' ');
                pause[3] = di[1];
                string requete = requeteSQL(Convert.ToString(pause[0]), Convert.ToString(pause[1]), Convert.ToDateTime(pause[2]), Convert.ToString(pause[3]), flag, idJeux
                    );
                sendRequeteSQL(requete);
                play = !play;
            }
        }
        public void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            watch.Stop();
            DateTime end = DateTime.Now;
            string duration = txtTimer.Text;
            if (f4duration != null)
            {
                duration = f4duration;
            }
            string requete = requeteSQL(startingDay, startingTime, end, duration, null, idJeux);
            sendRequeteSQL(requete);
            sessionCNED.ActiveForm.Close();
            GAME f2 = new GAME();
            Close();
            f2.Show();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {

        }
        private void btnRetour_Click(object sender, EventArgs e)
        {
            LEAVEGAME f4 = new LEAVEGAME();
            f4.startingDay = startingDay;
            f4.startingTime = startingTime;
            f4.flag = flag;
            f4.duration = txtTimer.Text;
            f4.idJeux = idJeux;
            f4.Show();
        }
        private void txtTimer_TextChanged(object sender, EventArgs e)
        {

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
        public string requeteSQL(string startingDay, string startingTime, DateTime endingTime, string duration, string drapeau, int idJeux)
        {
            if (drapeau is null)
            {
                return "INSERT INTO jeux_session (startingDay, startingTime, endingTime, duration, idJeux) VALUES " +
                "('" + startingDay + "','" + startingTime + "','" + endingTime + "','" + duration + "','" + idJeux + "')";
            }
            return "INSERT INTO pause (startingTime, endingTime, duration, drapeau, idDrapeau) VALUES " +
                "('" + startingTime + "','" + endingTime + "','" + duration + "','" + drapeau + "','" + idJeux + "')";
        }
    }
}
