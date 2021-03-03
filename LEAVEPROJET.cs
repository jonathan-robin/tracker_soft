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
    public partial class LEAVEPROJET : Form
    {
        public string startingDay;
        public string startingTime;
        public string connectionString = "server=localhost;database=tracker;uid=root;";
        public string flag;
        public string tableName;
        public string duration;
        public int idProjet;
        public LEAVEPROJET()
        {
            InitializeComponent();
        }

        private void LEAVEPROJET_Load(object sender, EventArgs e)
        {

        }

        private void btnOui_Click(object sender, EventArgs e)
        {
            Close();
            sessionProjet f3 = new sessionProjet();
            f3.Close();
            f3.startingDay = startingDay;
            f3.startingTime = startingTime;
            f3.f4duration = duration;
            f3.nomDuProjet = tableName;
            f3.idProjet = idProjet;
            f3.btnStop_Click(sender, e);
            Close();
            f3.Close();
            Close();
        }

        private void btnNon_Click(object sender, EventArgs e)
        {
            this.Hide();
            sessionProjet f3 = new sessionProjet();
            f3.startingDay = startingDay;
            f3.startingTime = startingTime;
            f3.f4duration = duration;
            f3.nomDuProjet = tableName;
            f3.idProjet = idProjet;
            PROJET f2 = new PROJET();
            f2.isOpenedWindow = true;
            f2.Show();
        }
    }
}
