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
    public partial class PROJET : Form
    {
        public string startingDay;
        public string startingTime;
        public string connectionString = "server=localhost;database=tracker;uid=root;";
        public string getRequete = "SELECT nomProjet FROM projet";
        public string flag;
        public string tableName;
        public string f4duration;
        public bool isOpenedWindow;
        public string nomProjet;
        public string descriptionProjet;
        public string dateCreationProjet;
        public string langageProjet;
        public int idProjet;
        public PROJET()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }  
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {         
        }
        public void getRequeteSQL()
        {
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(getRequete, cnn);
            cnn.Open();
            MySqlDataReader myReader = commandDatabase.ExecuteReader();
            try
            {           
                while(myReader.Read())
                {
                    lstbxProjet.Items.Add(String.Format("{0}", myReader["nomProjet"]));
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }

        }

        public void getIdProjet(string nomProjet)
        {
            var getID = "SELECT idProjet from projet where nomProjet = '" + nomProjet + "'";
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(getID, cnn); 
            try
            {
                cnn.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    idProjet = Convert.ToInt32(myReader[idProjet]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void sendRequestSQL(string requeteSQL)
        {
            MySqlConnection cnn = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(requeteSQL, cnn);
            try
            {
                cnn.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Projet bien ajouté !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "" || txtNomProjet.Text == "")
            {
                if (txtDescription.Text == "")
                {
                    MessageBox.Show("Veuillez rentrer une description");
                }
                else
                {
                    MessageBox.Show("Veuillez rentrer un nom de projet");
                }
            }
            else if(lstbLangage.CheckedItems.Count == 0)
            {
                MessageBox.Show("Veuillez saisir au moins un langage de programmation");
            }
            else
            {
                nomProjet = txtNomProjet.Text;
                descriptionProjet = txtDescription.Text;
                dateCreationProjet = DateTime.Now.ToString();
                for (int i = 0; i < lstbLangage.CheckedItems.Count; i++)
                {
                    langageProjet += lstbLangage.CheckedItems[i].ToString() + ";";
                }
                string requeteSQL = "INSERT INTO projet(nomProjet, langageProjet, descriptionProjet, dateCreationProjet) VALUES " +
                    "('" + nomProjet + "','" + langageProjet + "','" + descriptionProjet + "','" + dateCreationProjet + "')";
                txtDescription.Text = "";
                txtNomProjet.Text = "";
                sendRequestSQL(requeteSQL);
                PROJET_Load(sender, e);               
            }
            
        }

        private void PROJET_Load(object sender, EventArgs e)
        {
            lstbLangage.Items.Clear();
            string[] mesLangages = { "PHP", "JAVASCRIPT", "JAVA", "PYTHON", "HTML", "CSS", "C#", "C", "REACT", "REACT NATIVE", "VB", "ANGULAR", "VIEW" };
            lstbLangage.Items.AddRange(mesLangages);
            lstbLangage.Sorted = true;
            lstbLangage.CheckOnClick = true;           
            lstbLangage.CheckOnClick = true;           
            lstbxProjet.Items.Clear();
            getRequeteSQL();

            
        }
        private void lstbLangage_Click(object sender, EventArgs e)
        {

        }

        private void lstbLangage_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            txtNomProjet.Text = "";
            PROJET_Load(sender, e);
        }

        public void btnPlay_Click(object sender, EventArgs e)
        {
            if (lstbxProjet.SelectedItem != null)
            {
                nomProjet = lstbxProjet.SelectedItem.ToString();

                getIdProjet(nomProjet);
                sessionProjet f8 = new sessionProjet();
                f8.nomDuProjet = lstbxProjet.SelectedItem.ToString();
                Hide();
                f8.Show();
                DateTime Now = DateTime.Now;
                string[] now = Now.ToString().Split(' ');
                f8.startingDay = now[0];
                f8.startingTime = now[1];
                f8.idProjet = idProjet;

            }
            else
            {
                MessageBox.Show("Merci de saisir un projet pour commencer la session !");
            }
            
        }
        public void btnDelete_Click(object sender, EventArgs e)
        {
            PROJET_Load(sender, e);
        }

        private void lstbxProjet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Delete)
            {              
                if (lstbxProjet.SelectedItem != null)
                {
                    btnDelete_Click(sender, e);
                }
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
