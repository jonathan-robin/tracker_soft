namespace track3r
{
    partial class Track3r
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnFun = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.btnDev = new System.Windows.Forms.Button();
            this.btnCned = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFun
            // 
            this.btnFun.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnFun.BackgroundImage = global::track3r.Properties.Resources.images;
            this.btnFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.btnFun.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFun.Location = new System.Drawing.Point(445, 228);
            this.btnFun.Name = "btnFun";
            this.btnFun.Size = new System.Drawing.Size(404, 210);
            this.btnFun.TabIndex = 3;
            this.btnFun.UseVisualStyleBackColor = false;
            this.btnFun.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGame.BackgroundImage = global::track3r.Properties.Resources.CKjSDLdUsAAojV4__1_;
            this.btnGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.btnGame.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGame.Location = new System.Drawing.Point(12, 228);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(404, 210);
            this.btnGame.TabIndex = 2;
            this.btnGame.UseVisualStyleBackColor = false;
            // 
            // btnDev
            // 
            this.btnDev.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDev.BackgroundImage = global::track3r.Properties.Resources.dev2;
            this.btnDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.btnDev.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDev.Location = new System.Drawing.Point(445, 12);
            this.btnDev.Name = "btnDev";
            this.btnDev.Size = new System.Drawing.Size(404, 210);
            this.btnDev.TabIndex = 1;
            this.btnDev.UseVisualStyleBackColor = false;
            this.btnDev.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCned
            // 
            this.btnCned.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCned.BackgroundImage = global::track3r.Properties.Resources.téléchargement1;
            this.btnCned.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.btnCned.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCned.Location = new System.Drawing.Point(12, 12);
            this.btnCned.Name = "btnCned";
            this.btnCned.Size = new System.Drawing.Size(404, 210);
            this.btnCned.TabIndex = 0;
            this.btnCned.UseVisualStyleBackColor = false;
            this.btnCned.Click += new System.EventHandler(this.btnCned_Click);
            // 
            // Track3r
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(868, 584);
            this.Controls.Add(this.btnFun);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnDev);
            this.Controls.Add(this.btnCned);
            this.Name = "Track3r";
            this.Text = "Track3r";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCned;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDev;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnFun;
    }
}

