namespace track3r
{
    partial class DEV
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
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnLangage = new System.Windows.Forms.Button();
            this.btnProjet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.BackgroundImage = global::track3r.Properties.Resources.aze;
            this.btnRetour.Location = new System.Drawing.Point(12, 166);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(0);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(45, 42);
            this.btnRetour.TabIndex = 2;
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnLangage
            // 
            this.btnLangage.BackgroundImage = global::track3r.Properties.Resources.langage;
            this.btnLangage.Location = new System.Drawing.Point(200, 12);
            this.btnLangage.Name = "btnLangage";
            this.btnLangage.Size = new System.Drawing.Size(173, 131);
            this.btnLangage.TabIndex = 1;
            this.btnLangage.UseVisualStyleBackColor = true;
            this.btnLangage.Click += new System.EventHandler(this.btnLangage_Click);
            // 
            // btnProjet
            // 
            this.btnProjet.BackgroundImage = global::track3r.Properties.Resources.rojet;
            this.btnProjet.Location = new System.Drawing.Point(12, 12);
            this.btnProjet.Name = "btnProjet";
            this.btnProjet.Size = new System.Drawing.Size(173, 131);
            this.btnProjet.TabIndex = 0;
            this.btnProjet.UseVisualStyleBackColor = true;
            this.btnProjet.Click += new System.EventHandler(this.btnProjet_Click);
            // 
            // DEV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 217);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnLangage);
            this.Controls.Add(this.btnProjet);
            this.Name = "DEV";
            this.Text = "DEV";
            this.Load += new System.EventHandler(this.DEV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProjet;
        private System.Windows.Forms.Button btnLangage;
        private System.Windows.Forms.Button btnRetour;
    }
}