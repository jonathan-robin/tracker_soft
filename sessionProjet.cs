using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
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
    public partial class sessionProjet : Form
    {
        public string startingDay;

        public string startingTime;

        public string connectionString = "server=localhost;database=tracker;uid=root;";

        public string f4duration;

        object[] startingInfos = new object[2];

        object[] pause = new object[6];

        Stopwatch watch = new Stopwatch();

        bool play = true;

        public string nomDuProjet;

        public int idProjet;

        public static string commentaires;

        public static string objectifs;

        public static bool isVersionning;

        public static string cheminVersion;

        public static bool saveProjetSaving = false;

        public sessionProjet()
        {
            InitializeComponent();
        }

        private void sessionProjet_Load(object sender, EventArgs e)
        {
            Name = "Projet > " + nomDuProjet;
            lblNomDuProjet.Text = nomDuProjet;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            watch.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (play == true)
            {
                timer1.Stop();
                watch.Reset();
                while (saveProjetSaving == false)
                {
                    saveProjet();
                }
                saveProjetSaving = false;
                // Envoyer DB session
                DateTime end = DateTime.Now;
                string duration = txtTimer.Text;
                string requete = requeteSQL(startingDay, startingTime, end, duration, idProjet, null, objectifs, commentaires);
                sendRequeteSQL(requete);
                btnStop.Enabled = false;
                btnReset.Enabled = false;
                btnPause.BackgroundImage = Properties.Resources.playBackgroundImage;
                pause[0] = DateTime.Now;
                pause[1] = DateTime.Now;
                pause[5] = nomDuProjet;
                play = !play;
                MessageBox.Show("Session mise en pause !");
                commentaires = "";
                objectifs = "";
            }
            else
            {
                btnStop.Enabled = true;
                btnReset.Enabled = true;
                timer1.Start();
                watch.Start();

                btnPause.BackgroundImage = Properties.Resources.pause11;
                pause[4] = idProjet;
                pause[2] = DateTime.Now;
                startingTime = Convert.ToString(pause[2]).Split(' ')[1];
                TimeSpan diff = Convert.ToDateTime(pause[2]) - Convert.ToDateTime(pause[1]);
                DateTime dif = Convert.ToDateTime(string.Format("{0:00}:{1:00}:{2:00}", diff.Hours, diff.Minutes, diff.Seconds));
                string[] di = dif.ToString().Split(' ');
                pause[3] = di[1];
                string requete = requeteSQL(Convert.ToString(pause[0]), Convert.ToString(pause[1]), Convert.ToDateTime(pause[2]), Convert.ToString(pause[3]), Convert.ToInt32(pause[4])
                    , Convert.ToString(pause[5]), null, null);
                sendRequeteSQL(requete);
                play = !play;


            }
        }

        public string requeteSQL(string startingDay, string startingTime, DateTime endingTime, string duration, int IdProjet, string drapeau,
            string objectifs, string commentaires)
        {
            if (drapeau is null)
            {
                return "INSERT INTO projet_session (startingDay, startingTime, endingTime, duration, objectifs, commentaires, idProjet) VALUES " +
                "('" + startingDay + "','" + startingTime + "','" + endingTime + "','" + duration + "','" + objectifs + "','" + commentaires
              + "','" + IdProjet
              + "')";
            }
            return "INSERT INTO pause(startingTime, endingTime, duration, drapeau, idDrapeau) VALUES " +
                "('" + startingTime + "','" + endingTime + "','" + duration + "','projet','" + IdProjet
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

        public void saveProjet()
        {
            using(SAVEPROJET F3 = new SAVEPROJET())
            {
                if (F3.ShowDialog() == DialogResult.OK)
                {
                    F3.nomProjet = nomDuProjet;
                    objectifs = F3.objectifs;
                    commentaires = F3.commentaires;
                }
            }
        }

        public void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            watch.Stop();
            while (saveProjetSaving == false) {
                saveProjet();
            }
            saveProjetSaving = false;
                      

            MessageBox.Show(objectifs, commentaires);
            
            string duration = txtTimer.Text;
            if (f4duration != null)
            {
                duration = f4duration;
            }
            DateTime end = DateTime.Now;
            string requete = requeteSQL(startingDay, startingTime, end, duration, idProjet, null, objectifs, commentaires);
            sendRequeteSQL(requete);
            //Fermer sessionProjet 
            sessionProjet.ActiveForm.Close();
            commentaires = "";
            objectifs = "";
            PROJET f2 = new PROJET();
            f2.isOpenedWindow = false;
            f2.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            LEAVEPROJET f4 = new LEAVEPROJET();
            f4.startingDay = startingDay;
            f4.startingTime = startingTime;
            f4.flag = nomDuProjet;
            f4.tableName = nomDuProjet;
            f4.duration = txtTimer.Text;
            f4.idProjet = idProjet;
            f4.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan time = watch.Elapsed;
            txtTimer.Text = string.Format("{0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);
        }
    }
}
