using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace track3r
{
    public partial class SAVEPROJET : Form
    {
        public string objectifs;
        public string commentaires;
        public string nomProjet;
        public SAVEPROJET()
        {
            InitializeComponent();
        }

        private void SAVEPROJET_Load(object sender, EventArgs e)
        {
            rchTxtObjectifs.Focus();
            btnSave.Enabled = false;
            btnReset.Enabled = false;
            objectifs = "";
            commentaires = "";
            Text = "PROJET >" + nomProjet;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sessionProjet.saveProjetSaving = true;
            sessionProjet.commentaires = commentaires;
            sessionProjet.objectifs = objectifs;
            Close();
        }

        private void rchTxtObjectifs_TextChanged(object sender, EventArgs e)
        {
            objectifs = rchTxtObjectifs.Text;
            btnReset.Enabled = true;
            if (commentaires != "")
            {
                btnSave.Enabled = true;
            }
        }

        private void rchTxtCommentaires_TextChanged(object sender, EventArgs e)
        {
            commentaires = rchTxtCommentaires.Text;
            btnReset.Enabled = true;
            if (objectifs != "")
            {
                btnSave.Enabled = true; 
            }
        }

        private void chkBxVersionning_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rchTxtCommentaires.Text = "";
            commentaires = "";
            rchTxtObjectifs.Text = "";
            objectifs = "";
        }
    }
}
