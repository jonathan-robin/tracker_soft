using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace track3r
{
    public partial class SAVELANGAGE : Form
    {
        public string description, source, lien, probleme, nomLangage;
        public int idLangage;

        private void rchTxtProbleme_TextChanged(object sender, EventArgs e)
        {
            probleme = rchTxtProbleme.Text;
            btnReset.Enabled = true;
            if (description != "" && source != "" && lien != "")
            {
                btnSave.Enabled = true;
            }
        }

        private void rchTxtSource_TextChanged(object sender, EventArgs e)
        {
            source = rchTxtSource.Text;
            btnReset.Enabled = true;
            if (description != "" && probleme != "" && lien != "")
            {
                btnSave.Enabled = true;
            }
        }

        private void rchTxtLien_TextChanged(object sender, EventArgs e)
        {
            lien = rchTxtLien.Text;
            btnReset.Enabled = true;
            if (description != "" && source != "" && probleme != "")
            {
                btnSave.Enabled = true;
            }
        }

        private void rchTxtDescription_TextChanged(object sender, EventArgs e)
        {
            description = rchTxtDescription.Text;
            btnReset.Enabled = true;
            if (lien != "" && source != "" && probleme != "")
            {
                btnSave.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rchTxtDescription.Text = rchTxtSource.Text = rchTxtLien.Text = rchTxtProbleme.Text = "";
            source = description = lien = probleme = "";
        }

        private void SAVELANGAGE_Load(object sender, EventArgs e)
        {
            rchTxtProbleme.Focus();
            btnSave.Enabled = false;
            btnReset.Enabled = false;
            description = source = lien = probleme = "";
            Text = "LANGAGE >" + nomLangage;
        }

        public SAVELANGAGE()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sessionLangage.lien = lien;
            sessionLangage.description = description;
            sessionLangage.probleme = probleme;
            sessionLangage.source = source;
            Close();
        }
    }
}
