using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace track3r
{
    public partial class GAME : Form
    {
        public string game;
        public string openedWindow;
        public int idJeux;
        public string flag = "jeux";

        public GAME()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            if (openedWindow != null)
            {
                foreach (Button btn in this.Controls.OfType<Button>())
                {
                    btn.Enabled = false;
                }
            }
            btnRetour.Enabled = true;
        }
        public void LaunchF6(string flag, int idJeux)
        {
            DateTime Now = DateTime.Now;
            string[] info = Now.ToString().Split(' ');
            this.Close();
            INGAME f6 = new INGAME();
            this.Close();
            f6.startingDay = info[0];
            f6.startingTime = info[1];
            f6.flag = flag;
            f6.idJeux = idJeux;
            f6.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            idJeux = 4;
            LaunchF6(flag, idJeux);
            openedWindow = flag;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            idJeux =  2;
            LaunchF6(flag, idJeux);
            openedWindow = flag;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            idJeux = 5;
            LaunchF6(flag, idJeux);
            openedWindow = flag;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            idJeux = 3;
            LaunchF6(flag, idJeux);
            openedWindow = flag;
        }
        private void btnRetour_Click(object sender, EventArgs e)
        {
            Track3r f1 = new Track3r();
            this.Close();
            f1.ShowDialog();
        }
    }
}
