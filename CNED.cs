
using System;
using System.IO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace track3r
{
    public partial class CNED : Form
    {
        public string openedWindow;
        public CNED()
        {
            InitializeComponent();
        }
        private void launchF3(string flag)
        {         
            DateTime Now = DateTime.Now;
            string[] info = Now.ToString().Split(' ');
            this.Hide();
            sessionCNED f3 = new sessionCNED();
            f3.flag = flag;
            f3.startingDay = info[0];
            f3.startingTime = info[1];
            f3.ShowDialog();
        }
        private void btnAnglais_Click(object sender, EventArgs e)
        {
            string flag = "Anglais";
            openedWindow = flag;
            launchF3(flag);
        }
        private void btnComposantsLogiciels_Click(object sender, EventArgs e)
        {
            string flag = "Composants Logiciels";
            openedWindow = flag;
            launchF3(flag);
        }
        private void btnConceptionAdaptationBaseDonnees_Click(object sender, EventArgs e)
        {
            string flag =  "Conception Adaptation base de données";
            openedWindow = flag;
            launchF3(flag);
        }
        private void btnCultureG_Click(object sender, EventArgs e)
        {
            string flag = "Culture G";
            openedWindow = flag;
            launchF3(flag);
        }
        private void btnDroitEconomie_Click(object sender, EventArgs e)
        {
            string flag = "Droit Economie";
            openedWindow = flag;
            launchF3(flag);
        }
        private void btnIntegrationAdaptationService_Click(object sender, EventArgs e)
        {
            string flag = "Integration adaptation de services";
            openedWindow = flag;
            launchF3(flag);
        }
        private void btnMathematiques_Click(object sender, EventArgs e)
        {
            string flag = "Mathematiques";
            openedWindow = flag;
            launchF3(flag);
        }
        private void CNED_Load(object sender, EventArgs e)
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
        private void btnPPE_Click(object sender, EventArgs e)
        {
            string flag = "PPE";
            openedWindow = flag;
            launchF3(flag);
        }
        private void btnSolutionsApplicatives_Click(object sender, EventArgs e)
        {
            string flag = "Solutions Applicatives";
            openedWindow = flag;
            launchF3(flag);
        }
        private void btnRetour_Click(object sender, EventArgs e)
        {
            Hide();
            Track3r f1 = new Track3r();
            if (openedWindow != null)
            {               
                f1.openedWindowCned = true; 
            }       
            f1.Show();
        }
    }
}
