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

namespace track3r
{
    public partial class Form3 : Form
    {
        public string startingDay;
        public string startingTime;
        public string connectionString = "server=localhost;database=tracker;uid=root;";
        

        Stopwatch watch = new Stopwatch();
        bool play = true;
        public Form3()
        {          
            InitializeComponent();
               
        }
        private void Form3_Load(object sender, EventArgs e)
        {
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
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (play == true)
            {
                timer1.Stop();
                watch.Stop();
                btnPause.BackgroundImage = Properties.Resources.playBackgroundImage;
                play = false;
            }
            else
            {
                timer1.Start();
                watch.Start();
                btnPause.BackgroundImage = Properties.Resources.pause11;
                play = true;               
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            watch.Stop();
            DateTime end = DateTime.Now;
            string duration = txtTimer.Text;
            MySqlConnection cnn = new MySqlConnection(connectionString);
            string insertSession = "INSERT INTO anglais(startingDay, startingTime, endingTime, duration) VALUES " +
                "('" + startingDay + "','" + startingTime + "','" + end + "','" + duration + "')";
            MySqlCommand commandDatabase = new MySqlCommand(insertSession, cnn);
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
    }
}
