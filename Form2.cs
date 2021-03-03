
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

        
        public CNED()
        {
            InitializeComponent();
        }

        private void btnAnglais_Click(object sender, EventArgs e)
        {                   
            DateTime Now = DateTime.Now;
            string[] info = Now.ToString().Split(' ');
            
            this.Hide();
            Form3 f3 = new Form3();
            f3.startingDay = info[0];
            f3.startingTime = info[1];
            f3.ShowDialog();      
        }
    }
}
