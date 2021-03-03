using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Security;
using System.Management.Instrumentation;
using System.Collections.ObjectModel;
using System.Management.Automation;

using System.Net.Http;


using System.Web.Http;
using System.Web.Http.SelfHost;
using System.Web.Mvc;
using TestingReactDotNet.Controllers;

namespace track3r
{
    
    public partial class STATSCALENDAR : Form
    {

        

        public string connectionString = "server=localhost;database=tracker;uid=root;";
        public string getDataLangageQuery = "SELECT nomLangage FROM LANGAGE";
        public string getDataJeuxQuery = "SELECT nomJeux from JEUX";
        public string getDataProjetQuery = "SELECT nomProjet from PROJET";
        public string getDataCNEDQuery = "SELECT nomMatiere from MATIERE";
        public DateTime today = DateTime.Today;
        public DateTime derniers7jours = DateTime.Today.AddDays(-7);
        public DateTime derniers30jours = DateTime.Today.AddDays(-30);
        public DateTime startWeek = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
        public int month = DateTime.Today.Month;
        public DateTime debutCal, finCal;
        private static readonly HttpClient client = new HttpClient();
        public STATSCALENDAR()
        {
            InitializeComponent();
        }
        private void STATSCALENDAR_Load(object sender, EventArgs e)
        {
            getDataSQL(getDataLangageQuery, cbBxLangage, "nomLangage");
            getDataSQL(getDataJeuxQuery, cbBxJeux, "nomJeux");
            getDataSQL(getDataProjetQuery, cbBxProjet, "nomProjet");
            getDataSQL(getDataCNEDQuery, cbBxCNED, "nomMatiere");

            string septjours = derniers7jours.ToString() + " " + today.ToString();
            string trentejours = derniers30jours.ToString() + "%" + today.ToString();
            string semaine = startWeek.ToString() + "%" + today.ToString();

            btnLancerRechercheDate.Enabled = false;
        }
        private void cbBxCNED_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void getDataSQL(string dataQuery, ComboBox cbBx, string Reader)
        {
            cbBx.Items.Clear();
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(dataQuery, cnn);
            cnn.Open();
            MySqlDataReader myReader = commandDatabase.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    cbBx.Items.Add(String.Format("{0}", myReader[Reader]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void GetError()
        {
            var script = @"C:\Users\Jonathan\Desktop\script.ps1";
            var startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy unrestricted \"{script}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }

        private void btnJour_Click(object sender, EventArgs e)
        {
            MessageBox.Show(today.ToString());
            GetError();
            DisplayNameController controller = new DisplayNameController();
            string response = controller.Greeting("Jo");
            MessageBox.Show(response);
            //TestingReactDotNet.Controllers.DisplayNameController; ("Jo");
        }

        private void btnSemaine_Click(object sender, EventArgs e)
        {
            MessageBox.Show(derniers7jours.ToString(), today.ToString());
        }

        private void btnLancerRechercheDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show((debutCal, finCal).ToString());

        }

        private void mthCalFin_DateChanged(object sender, DateRangeEventArgs e)
        {
            finCal = Convert.ToDateTime(mthCalFin.SelectionRange.End.ToString());
            if (debutCal.ToString() != "01/01/0001 00:00:00")
            {
                btnLancerRechercheDate.Enabled = true;
            }
        }
        private void btnSemaine_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(startWeek.ToString(), today.ToString());
        }

        private void btnMois_Click(object sender, EventArgs e)
        {
            MessageBox.Show(month.ToString());
        }

        private void btn30j_Click(object sender, EventArgs e)
        {
            MessageBox.Show(derniers30jours.ToString(), today.ToString());
        }

        private void mthCalDebut_DateChanged(object sender, DateRangeEventArgs e)
        {
            debutCal = Convert.ToDateTime(mthCalDebut.SelectionRange.Start.ToString());
            if (finCal.ToString() != "01/01/0001 00:00:00")
            {
                btnLancerRechercheDate.Enabled = true;
            }
        }
    }
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}
