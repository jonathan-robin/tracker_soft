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
    public partial class DEV : Form
    {
        public bool isOpenedWindow;
        public DEV()
        {
            InitializeComponent();
        }

        private void DEV_Load(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Track3r f4 = new Track3r();
            Hide();
            f4.Show();
            
        }

        private void btnProjet_Click(object sender, EventArgs e)
        {
            PROJET f1 = new PROJET();
            Hide();
            f1.Show();
        }

        private void btnLangage_Click(object sender, EventArgs e)
        {
            LANGAGE f2 = new LANGAGE();
            Hide();
            f2.Show();
        }
    }
}
