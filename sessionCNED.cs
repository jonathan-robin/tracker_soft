using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using static System.Windows.Forms.Timer;
using System.Security.Policy;
using MySql.Data.MySqlClient;
using static System.Drawing.Image;
using static System.Drawing.Bitmap;
using MySqlX.XDevAPI.Relational;
using System.Timers;

namespace track3r
{
    public partial class sessionCNED : Form
    {
        public string startingDay;
        public string startingTime;
        public string connectionString = "server=localhost;database=tracker;uid=root;";
        public string flag;
        public string tableName;
        public string f4duration;
        public int idMatiere;
        object[] startingInfos = new object[2];
        object[] pause = new object[6];
        Stopwatch watch = new Stopwatch();
        bool play = true;
        public sessionCNED()
        {
            InitializeComponent();

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            switch (flag)
            {
                case "Anglais":
                    idMatiere = 1;
                    break;
                case "Composants Logiciels":
                    idMatiere = 2;
                    break;
                case "Conception Adaptation base de données":
                    idMatiere = 3;
                    break;
                case "Culture G":
                    idMatiere = 7;
                    break;
                case "Droit Economie":
                    idMatiere = 4;
                    break;
                case "Integration adaptation de services":
                    idMatiere = 5;
                    break;
                case "Mathematiques":
                    idMatiere = 6;
                    break;
                case "PPE":
                    idMatiere =9;
                    break;
                case "Solutions Applicatives":
                    idMatiere =8;
                    break;
            }
            Text = "CNED > " + flag;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            watch.Start();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        public void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan time = watch.Elapsed;
            txtTimer.Text = string.Format("{0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
        }
        public void timer1_Reset()
        {
            timer1.Stop();
            timer1.Start();
        }
        public void watch_reset()
        {
            watch.Stop();
            watch.Start();
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (play == true)
            {
                timer1.Stop();
                watch.Stop();
                watch.Reset();
                // Envoyer DB session
                DateTime end = DateTime.Now;
                string duration = txtTimer.Text;
                string requete = requeteSQL(startingDay, startingTime, end, duration, idMatiere, null);
                sendRequeteSQL(requete);
                btnStop.Enabled = false;
                btnReset.Enabled = false;              
                btnPause.BackgroundImage = Properties.Resources.playBackgroundImage;
                pause[0] = DateTime.Now;
                pause[1] = DateTime.Now;
                pause[5] = flag;
                play = !play;
                MessageBox.Show("Session mise en pause !");   
            }
            else
            {   
                btnStop.Enabled = true;
                btnReset.Enabled = true;
                timer1.Start();
                watch.Start();

                btnPause.BackgroundImage = Properties.Resources.pause11;               
                pause[2] = DateTime.Now;
                startingTime = Convert.ToString(pause[2]).Split(' ')[1];
                TimeSpan diff = Convert.ToDateTime(pause[2]) - Convert.ToDateTime(pause[1]);
                DateTime dif = Convert.ToDateTime(string.Format("{0:00}:{1:00}:{2:00}", diff.Hours, diff.Minutes, diff.Seconds));
                string[] di = dif.ToString().Split(' ');
                pause[3] = di[1];
                string requete = requeteSQL(Convert.ToString(pause[0]), Convert.ToString(pause[1]), Convert.ToDateTime(pause[2]), Convert.ToString(pause[3]), idMatiere
                    , Convert.ToString(pause[5]));
                sendRequeteSQL(requete);
                play = !play;


            }
        }

        public string requeteSQL(string startingDay, string startingTime, DateTime endingTime, string duration, int idMatiere, string drapeau)
        {
            if (drapeau is null)
            {
                return "INSERT INTO matiere_session (startingDay, startingTime, endingTime, duration, idMatiere) VALUES " +
                "('" + startingDay + "','" + startingTime + "','" + endingTime + "','" + duration + "','" + idMatiere + "')";
            }
            return "INSERT INTO pause(startingTime, endingTime, duration, drapeau, idDrapeau) VALUES " +
                "('" + startingTime + "','" + endingTime + "','" + duration + "','matiere','" + idMatiere + "')";
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

        public void btnStop_Click(object sender, EventArgs e)
        {
            Close();
            timer1.Stop();
            watch.Stop();
            DateTime end = DateTime.Now;
            string duration = txtTimer.Text;
            if (f4duration != null)
            {
                duration = f4duration;
            }
            string requete = requeteSQL(startingDay, startingTime, end, duration, idMatiere, null);
            sendRequeteSQL(requete);
            sessionCNED.ActiveForm.Close();
            CNED f2 = new CNED();
            f2.openedWindow = null;
            Close();
            f2.Show();           
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            LEAVE f4 = new LEAVE();
            f4.startingDay = startingDay;
            f4.startingTime = startingTime;
            f4.flag = flag;
            f4.tableName = tableName;
            f4.duration = txtTimer.Text;
            f4.idMatiere = idMatiere;
            f4.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void txtTimer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
