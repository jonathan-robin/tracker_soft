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
    public partial class LEAVEGAME : Form
    {
        public string startingDay;
        public string startingTime;
        public string connectionString = "server=localhost;database=tracker;uid=root;";
        public string flag;
        public int idJeux;
        public string duration;
        public LEAVEGAME()
        {
            InitializeComponent();
        }
        private void Form7_Load(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnOui_Click(object sender, EventArgs e)
        {
            Close();
            INGAME f3 = new INGAME();
            f3.Close();
            f3.startingDay = startingDay;
            f3.startingTime = startingTime;
            f3.f4duration = duration;
            f3.idJeux = idJeux;
            f3.btnStop_Click(sender, e);
            GAME f2 = new GAME();
        }
        private void btnNon_Click(object sender, EventArgs e)
        {
            this.Hide();
            INGAME f3 = new INGAME();
            f3.startingDay = startingDay;
            f3.startingTime = startingTime;
            f3.f4duration = duration;
            f3.idJeux = idJeux;
            GAME f2 = new GAME();
            f2.openedWindow = flag;
            f2.Show();
        }
    }
}
