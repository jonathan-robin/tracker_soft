namespace track3r
{
    partial class PROJET
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstbxProjet = new System.Windows.Forms.ListBox();
            this.txtNomProjet = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNomProjet = new System.Windows.Forms.Label();
            this.grbxNewProject = new System.Windows.Forms.GroupBox();
            this.lstbLangage = new System.Windows.Forms.CheckedListBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLangage = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grbxNewProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbxProjet
            // 
            this.lstbxProjet.FormattingEnabled = true;
            this.lstbxProjet.Location = new System.Drawing.Point(13, 13);
            this.lstbxProjet.Name = "lstbxProjet";
            this.lstbxProjet.Size = new System.Drawing.Size(189, 251);
            this.lstbxProjet.TabIndex = 0;
            this.lstbxProjet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstbxProjet_KeyDown);
            // 
            // txtNomProjet
            // 
            this.txtNomProjet.Location = new System.Drawing.Point(28, 41);
            this.txtNomProjet.Name = "txtNomProjet";
            this.txtNomProjet.Size = new System.Drawing.Size(195, 20);
            this.txtNomProjet.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(28, 179);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(195, 96);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.Text = "";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(28, 285);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "AJOUTER";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(138, 285);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNomProjet
            // 
            this.lblNomProjet.AutoSize = true;
            this.lblNomProjet.Location = new System.Drawing.Point(28, 21);
            this.lblNomProjet.Name = "lblNomProjet";
            this.lblNomProjet.Size = new System.Drawing.Size(86, 13);
            this.lblNomProjet.TabIndex = 10;
            this.lblNomProjet.Text = "Nom du Projet ...";
            // 
            // grbxNewProject
            // 
            this.grbxNewProject.Controls.Add(this.lstbLangage);
            this.grbxNewProject.Controls.Add(this.lblDescription);
            this.grbxNewProject.Controls.Add(this.lblLangage);
            this.grbxNewProject.Controls.Add(this.txtDescription);
            this.grbxNewProject.Controls.Add(this.btnAjouter);
            this.grbxNewProject.Controls.Add(this.btnReset);
            this.grbxNewProject.Controls.Add(this.lblNomProjet);
            this.grbxNewProject.Controls.Add(this.txtNomProjet);
            this.grbxNewProject.Location = new System.Drawing.Point(282, 13);
            this.grbxNewProject.Name = "grbxNewProject";
            this.grbxNewProject.Size = new System.Drawing.Size(237, 320);
            this.grbxNewProject.TabIndex = 11;
            this.grbxNewProject.TabStop = false;
            this.grbxNewProject.Text = "Nouveau Projet...";
            this.grbxNewProject.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lstbLangage
            // 
            this.lstbLangage.FormattingEnabled = true;
            this.lstbLangage.Location = new System.Drawing.Point(107, 74);
            this.lstbLangage.Name = "lstbLangage";
            this.lstbLangage.Size = new System.Drawing.Size(116, 79);
            this.lstbLangage.Sorted = true;
            this.lstbLangage.TabIndex = 12;
            this.lstbLangage.ThreeDCheckBoxes = true;
            this.lstbLangage.Click += new System.EventHandler(this.lstbLangage_Click);
            this.lstbLangage.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            this.lstbLangage.SelectedValueChanged += new System.EventHandler(this.lstbLangage_SelectedValueChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(29, 159);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 13);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description ...";
            this.lblDescription.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblLangage
            // 
            this.lblLangage.AutoSize = true;
            this.lblLangage.Location = new System.Drawing.Point(28, 74);
            this.lblLangage.Name = "lblLangage";
            this.lblLangage.Size = new System.Drawing.Size(61, 13);
            this.lblLangage.TabIndex = 11;
            this.lblLangage.Text = "Langage ...";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::track3r.Properties.Resources.stop1;
            this.btnDelete.Location = new System.Drawing.Point(155, 270);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(47, 44);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackgroundImage = global::track3r.Properties.Resources.aze;
            this.btnRetour.Location = new System.Drawing.Point(13, 272);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(0);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(45, 42);
            this.btnRetour.TabIndex = 9;
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::track3r.Properties.Resources.il_570xN_1563938723_1rmr;
            this.btnPlay.Location = new System.Drawing.Point(208, 19);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(68, 54);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // PROJET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 335);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grbxNewProject);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lstbxProjet);
            this.Name = "PROJET";
            this.Text = "Dev > Projet";
            this.Load += new System.EventHandler(this.PROJET_Load);
            this.grbxNewProject.ResumeLayout(false);
            this.grbxNewProject.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxProjet;
        private System.Windows.Forms.TextBox txtNomProjet;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblNomProjet;
        private System.Windows.Forms.GroupBox grbxNewProject;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblLangage;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.CheckedListBox lstbLangage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Timer timer1;
    }
}