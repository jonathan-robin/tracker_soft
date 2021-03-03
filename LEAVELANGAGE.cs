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
    public partial class LEAVELANGAGE : Form
    {
        public string startingDay, startingTime, nomLangage, duration;
        public string connectionString = "server=localhost;database=tracker;uid=root;";
        public int idLangage;
        private void btnNon_Click(object sender, EventArgs e)
        {
            this.Hide();
            sessionLangage f3 = new sessionLangage();
            f3.startingDay = startingDay;
            f3.startingTime = startingTime;
            f3.f4duration = duration;
            f3.nomLangage = nomLangage;
            f3.idLangage = idLangage;
            DEV f2 = new DEV();
            f2.isOpenedWindow = true;
            f2.Show();
        }

        public LEAVELANGAGE()
        {
            InitializeComponent();
        }

        private void LEAVELANGAGE_Load(object sender, EventArgs e)
        {

        }

        private void btnOui_Click(object sender, EventArgs e)
        {
            Close();
            sessionLangage f3 = new sessionLangage();
            f3.Close();
            f3.startingDay = startingDay;
            f3.startingTime = startingTime;
            f3.f4duration = duration;
            f3.nomLangage = nomLangage;
            f3.idLangage = idLangage;
            f3.btnStop_Click(sender, e);
            Close();
            f3.Close();
            Close();
        }
    }
}
