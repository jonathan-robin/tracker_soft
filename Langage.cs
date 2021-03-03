using MySql.Data.MySqlClient;
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
    public partial class LANGAGE : Form
    {

        public string connectionString = "server=localhost;database=tracker;uid=root;";
        public string getLangage = "SELECT nomLangage FROM langage";
        public string newLangage = "";
        public int idLangage;
        public LANGAGE()
        {
            InitializeComponent();
        }
        private void Form13_Load(object sender, EventArgs e)
        {
            lstBxLangage.Items.Clear();
            getLangageSQL();
            lstBxLangage.Sorted = true;
            lstBxLangage.CheckOnClick = true;
            lstBxLangage.CheckOnClick = true;
        }

        public void getIdLangage(string nomLangage)
        {
            string requeteGetIdLangage = "SELECT idLangage FROM LANGAGE where nomLangage = '" + nomLangage + "';"; 
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(requeteGetIdLangage, cnn);
            cnn.Open();
            MySqlDataReader myReader = commandDatabase.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    idLangage = Convert.ToInt32(myReader["idLangage"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void getLangageSQL()
        {
            lstBxLangage.Items.Clear();
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(getLangage, cnn);
            cnn.Open();
            MySqlDataReader myReader = commandDatabase.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    lstBxLangage.Items.Add(String.Format("{0}", myReader["nomLangage"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CreateTrackerSQL(string requeteSQL)
        {
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(requeteSQL, cnn);
            try
            {
                cnn.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void addNewLangage(string langage)
        {
            string query = "INSERT INTO LANGAGE (nomLangage) VALUES ('" + langage + "')";
            MessageBox.Show("Langage bien ajouté !");
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand commandDataBase = new MySqlCommand(query, cnn);
            try
            {
                cnn.Open();
                MySqlDataReader myReader = commandDataBase.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                /* string requeteTrackerSQL = "CREATE TABLE " + newLangage + "(session int PRIMARY KEY AUTO_INCREMENT,startingDay text, startingTime text, endingTime text, duration text," +
                " source text, probleme text, lien text, description text)";*/
                txtLangage.Text = "";
               /* CreateTrackerSQL(requeteTrackerSQL);*/
                getLangageSQL(); 
        }



        private void lstBxLangage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newLangage = txtLangage.Text;
            if (txtLangage.Text != "")
            {
                addNewLangage(newLangage);
            }
            else
            {
                MessageBox.Show("Merci de saisir un langage de programmation.");   
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (lstBxLangage.SelectedItem != null)
            {
                getIdLangage(lstBxLangage.SelectedItem.ToString());
                sessionLangage f1 = new sessionLangage();
                f1.nomLangage = lstBxLangage.SelectedItem.ToString();
                Hide();
                f1.Show();
                DateTime Now = DateTime.Now;
                string[] now = Now.ToString().Split(' ');
                f1.startingDay = now[0];
                f1.startingTime = now[1];
                f1.idLangage = idLangage;
            }
            else
            {
                MessageBox.Show("Merci de saisir un langage pour commencer la session !");
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            DEV f1 = new DEV();
            Hide();
            f1.Show();
        }
    }
}
