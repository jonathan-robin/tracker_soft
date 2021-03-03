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
    public partial class LEAVE : Form
    {
        public string startingDay;
        public string startingTime;
        public string connectionString = "server=localhost;database=tracker;uid=root;";
        public string flag;
        public string tableName;
        public string duration;
        public int idMatiere;
        public LEAVE()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            sessionCNED f3 = new sessionCNED();
            f3.Close();
            f3.startingDay = startingDay;
            f3.startingTime = startingTime;
            f3.f4duration = duration;
            f3.tableName = tableName;
            f3.idMatiere = idMatiere;
            f3.btnStop_Click(sender, e);
            Close();
            f3.Close();
            Close();
        }

        private void btnNon_Click(object sender, EventArgs e)
        {
            this.Hide();
            sessionCNED f3 = new sessionCNED();
            f3.startingDay = startingDay;
            f3.startingTime = startingTime;
            f3.f4duration = duration;
            f3.tableName = tableName;
            CNED f2 = new CNED();
            f2.openedWindow = flag;
            f2.Show();           
        }
    }
}
