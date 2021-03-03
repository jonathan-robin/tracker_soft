using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace track3r
{
    public partial class Track3r : Form
    {
        public bool openedWindowGame;
        public bool openedWindowCned;
        public bool openedWindowFun;
        public bool openedWindowDev;
        public Track3r()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnCned_Click(object sender, EventArgs e)
        {
            CNED f2 = new CNED();
            if (openedWindowCned) {
                f2.openedWindow = "true";
            }
            f2.Show();
            Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DEV f6 = new DEV();
            f6.Show();
        }       
        private void button3_Click(object sender, EventArgs e)
        {
          
        }
        private void btnGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            GAME f5 = new GAME();
            if (openedWindowGame)
            {
                f5.openedWindow = "true";
            }
            f5.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            STATSCALENDAR f7 = new STATSCALENDAR();
            Hide();
            f7.Show();
        }
    }
}
