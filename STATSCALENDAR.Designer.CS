namespace track3r
{
    partial class STATSCALENDAR
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
            this.mthCalDebut = new System.Windows.Forms.MonthCalendar();
            this.mthCalFin = new System.Windows.Forms.MonthCalendar();
            this.btnJour = new System.Windows.Forms.Button();
            this.btn7jours = new System.Windows.Forms.Button();
            this.btn30j = new System.Windows.Forms.Button();
            this.btnMois = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLancerRechercheDate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSemaine = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLancerRechercheSujet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBxLangage = new System.Windows.Forms.ComboBox();
            this.cbBxProjet = new System.Windows.Forms.ComboBox();
            this.cbBxJeux = new System.Windows.Forms.ComboBox();
            this.cbBxCNED = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mthCalDebut
            // 
            this.mthCalDebut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mthCalDebut.Location = new System.Drawing.Point(19, 48);
            this.mthCalDebut.MaxSelectionCount = 36500;
            this.mthCalDebut.Name = "mthCalDebut";
            this.mthCalDebut.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2019, 12, 30, 0, 0, 0, 0), new System.DateTime(2021, 12, 29, 0, 0, 0, 0));
            this.mthCalDebut.ShowTodayCircle = false;
            this.mthCalDebut.TabIndex = 0;
            this.mthCalDebut.TodayDate = new System.DateTime(2020, 12, 29, 0, 0, 0, 0);
            this.mthCalDebut.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mthCalDebut_DateChanged);
            // 
            // mthCalFin
            // 
            this.mthCalFin.Location = new System.Drawing.Point(303, 48);
            this.mthCalFin.MaxSelectionCount = 36555;
            this.mthCalFin.Name = "mthCalFin";
            this.mthCalFin.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2019, 12, 29, 0, 0, 0, 0), new System.DateTime(2022, 1, 4, 0, 0, 0, 0));
            this.mthCalFin.TabIndex = 1;
            this.mthCalFin.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mthCalFin_DateChanged);
            // 
            // btnJour
            // 
            this.btnJour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJour.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJour.Location = new System.Drawing.Point(10, 19);
            this.btnJour.Name = "btnJour";
            this.btnJour.Size = new System.Drawing.Size(141, 23);
            this.btnJour.TabIndex = 2;
            this.btnJour.Text = "Aujourd\'hui";
            this.btnJour.UseVisualStyleBackColor = true;
            this.btnJour.Click += new System.EventHandler(this.btnJour_Click);
            // 
            // btn7jours
            // 
            this.btn7jours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7jours.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7jours.Location = new System.Drawing.Point(10, 57);
            this.btn7jours.Name = "btn7jours";
            this.btn7jours.Size = new System.Drawing.Size(227, 23);
            this.btn7jours.TabIndex = 3;
            this.btn7jours.Text = "les 7 derniers jours";
            this.btn7jours.UseVisualStyleBackColor = true;
            this.btn7jours.Click += new System.EventHandler(this.btnSemaine_Click);
            // 
            // btn30j
            // 
            this.btn30j.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn30j.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn30j.Location = new System.Drawing.Point(256, 57);
            this.btn30j.Name = "btn30j";
            this.btn30j.Size = new System.Drawing.Size(227, 23);
            this.btn30j.TabIndex = 4;
            this.btn30j.Text = "Les 30 derniers jours";
            this.btn30j.UseVisualStyleBackColor = true;
            this.btn30j.Click += new System.EventHandler(this.btn30j_Click);
            // 
            // btnMois
            // 
            this.btnMois.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMois.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMois.Location = new System.Drawing.Point(342, 19);
            this.btnMois.Name = "btnMois";
            this.btnMois.Size = new System.Drawing.Size(141, 23);
            this.btnMois.TabIndex = 5;
            this.btnMois.Text = "Ce mois-ci";
            this.btnMois.UseVisualStyleBackColor = true;
            this.btnMois.Click += new System.EventHandler(this.btnMois_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Début de la période";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fin de la période";
            // 
            // btnLancerRechercheDate
            // 
            this.btnLancerRechercheDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLancerRechercheDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLancerRechercheDate.FlatAppearance.BorderSize = 0;
            this.btnLancerRechercheDate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnLancerRechercheDate.Location = new System.Drawing.Point(385, 220);
            this.btnLancerRechercheDate.Margin = new System.Windows.Forms.Padding(0);
            this.btnLancerRechercheDate.Name = "btnLancerRechercheDate";
            this.btnLancerRechercheDate.Size = new System.Drawing.Size(145, 44);
            this.btnLancerRechercheDate.TabIndex = 9;
            this.btnLancerRechercheDate.Text = "Lancer la recherche ";
            this.btnLancerRechercheDate.UseVisualStyleBackColor = false;
            this.btnLancerRechercheDate.Click += new System.EventHandler(this.btnLancerRechercheDate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSemaine);
            this.groupBox1.Controls.Add(this.btnJour);
            this.groupBox1.Controls.Add(this.btn7jours);
            this.groupBox1.Controls.Add(this.btn30j);
            this.groupBox1.Controls.Add(this.btnMois);
            this.groupBox1.Location = new System.Drawing.Point(13, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 97);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche rapide";
            // 
            // btnSemaine
            // 
            this.btnSemaine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSemaine.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemaine.Location = new System.Drawing.Point(179, 19);
            this.btnSemaine.Name = "btnSemaine";
            this.btnSemaine.Size = new System.Drawing.Size(141, 23);
            this.btnSemaine.TabIndex = 6;
            this.btnSemaine.Text = "Cette semaine";
            this.btnSemaine.UseVisualStyleBackColor = true;
            this.btnSemaine.Click += new System.EventHandler(this.btnSemaine_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLancerRechercheSujet);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbBxLangage);
            this.groupBox2.Controls.Add(this.cbBxProjet);
            this.groupBox2.Controls.Add(this.cbBxJeux);
            this.groupBox2.Controls.Add(this.cbBxCNED);
            this.groupBox2.Location = new System.Drawing.Point(37, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 194);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche par sujet";
            // 
            // btnLancerRechercheSujet
            // 
            this.btnLancerRechercheSujet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLancerRechercheSujet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLancerRechercheSujet.FlatAppearance.BorderSize = 0;
            this.btnLancerRechercheSujet.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnLancerRechercheSujet.Location = new System.Drawing.Point(296, 136);
            this.btnLancerRechercheSujet.Margin = new System.Windows.Forms.Padding(0);
            this.btnLancerRechercheSujet.Name = "btnLancerRechercheSujet";
            this.btnLancerRechercheSujet.Size = new System.Drawing.Size(145, 44);
            this.btnLancerRechercheSujet.TabIndex = 12;
            this.btnLancerRechercheSujet.Text = "Lancer la recherche ";
            this.btnLancerRechercheSujet.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Langage DEV";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Projet DEV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Jeux";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matière CNED";
            // 
            // cbBxLangage
            // 
            this.cbBxLangage.FormattingEnabled = true;
            this.cbBxLangage.Location = new System.Drawing.Point(270, 106);
            this.cbBxLangage.Name = "cbBxLangage";
            this.cbBxLangage.Size = new System.Drawing.Size(171, 21);
            this.cbBxLangage.TabIndex = 3;
            // 
            // cbBxProjet
            // 
            this.cbBxProjet.FormattingEnabled = true;
            this.cbBxProjet.Location = new System.Drawing.Point(19, 106);
            this.cbBxProjet.Name = "cbBxProjet";
            this.cbBxProjet.Size = new System.Drawing.Size(171, 21);
            this.cbBxProjet.TabIndex = 2;
            // 
            // cbBxJeux
            // 
            this.cbBxJeux.FormattingEnabled = true;
            this.cbBxJeux.Location = new System.Drawing.Point(270, 49);
            this.cbBxJeux.Name = "cbBxJeux";
            this.cbBxJeux.Size = new System.Drawing.Size(171, 21);
            this.cbBxJeux.TabIndex = 1;
            // 
            // cbBxCNED
            // 
            this.cbBxCNED.FormattingEnabled = true;
            this.cbBxCNED.Location = new System.Drawing.Point(19, 49);
            this.cbBxCNED.Name = "cbBxCNED";
            this.cbBxCNED.Size = new System.Drawing.Size(171, 21);
            this.cbBxCNED.TabIndex = 0;
            this.cbBxCNED.SelectedIndexChanged += new System.EventHandler(this.cbBxCNED_SelectedIndexChanged);
            // 
            // STATSCALENDAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 598);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLancerRechercheDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mthCalFin);
            this.Controls.Add(this.mthCalDebut);
            this.Name = "STATSCALENDAR";
            this.Text = "STATSCALENDAR";
            this.Load += new System.EventHandler(this.STATSCALENDAR_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mthCalDebut;
        private System.Windows.Forms.MonthCalendar mthCalFin;
        private System.Windows.Forms.Button btnJour;
        private System.Windows.Forms.Button btn7jours;
        private System.Windows.Forms.Button btn30j;
        private System.Windows.Forms.Button btnMois;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLancerRechercheDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBxLangage;
        private System.Windows.Forms.ComboBox cbBxProjet;
        private System.Windows.Forms.ComboBox cbBxJeux;
        private System.Windows.Forms.ComboBox cbBxCNED;
        private System.Windows.Forms.Button btnLancerRechercheSujet;
        private System.Windows.Forms.Button btnSemaine;
    }
}