namespace track3r
{
    partial class LANGAGE
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
            this.lstBxLangage = new System.Windows.Forms.CheckedListBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.grBxNewLangage = new System.Windows.Forms.GroupBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNomLangage = new System.Windows.Forms.Label();
            this.txtLangage = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.grBxNewLangage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBxLangage
            // 
            this.lstBxLangage.FormattingEnabled = true;
            this.lstBxLangage.Location = new System.Drawing.Point(12, 12);
            this.lstBxLangage.Name = "lstBxLangage";
            this.lstBxLangage.Size = new System.Drawing.Size(152, 184);
            this.lstBxLangage.Sorted = true;
            this.lstBxLangage.TabIndex = 13;
            this.lstBxLangage.ThreeDCheckBoxes = true;
            this.lstBxLangage.SelectedIndexChanged += new System.EventHandler(this.lstBxLangage_SelectedIndexChanged);
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnGo.Location = new System.Drawing.Point(337, 142);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(68, 54);
            this.btnGo.TabIndex = 15;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // grBxNewLangage
            // 
            this.grBxNewLangage.Controls.Add(this.btnAjouter);
            this.grBxNewLangage.Controls.Add(this.btnReset);
            this.grBxNewLangage.Controls.Add(this.btnAdd);
            this.grBxNewLangage.Controls.Add(this.lblNomLangage);
            this.grBxNewLangage.Controls.Add(this.txtLangage);
            this.grBxNewLangage.Location = new System.Drawing.Point(170, 12);
            this.grBxNewLangage.Name = "grBxNewLangage";
            this.grBxNewLangage.Size = new System.Drawing.Size(235, 123);
            this.grBxNewLangage.TabIndex = 16;
            this.grBxNewLangage.TabStop = false;
            this.grBxNewLangage.Text = "Nouveau Langage...";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(28, 285);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "AJOUTER";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(138, 285);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblNomLangage
            // 
            this.lblNomLangage.AutoSize = true;
            this.lblNomLangage.Location = new System.Drawing.Point(28, 21);
            this.lblNomLangage.Name = "lblNomLangage";
            this.lblNomLangage.Size = new System.Drawing.Size(101, 13);
            this.lblNomLangage.TabIndex = 10;
            this.lblNomLangage.Text = "Nom du Langage ...";
            // 
            // txtLangage
            // 
            this.txtLangage.Location = new System.Drawing.Point(28, 41);
            this.txtLangage.Name = "txtLangage";
            this.txtLangage.Size = new System.Drawing.Size(195, 20);
            this.txtLangage.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::track3r.Properties.Resources.ajouter;
            this.btnAdd.Location = new System.Drawing.Point(170, 67);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 50);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackgroundImage = global::track3r.Properties.Resources.aze;
            this.btnRetour.Location = new System.Drawing.Point(170, 154);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(0);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(45, 42);
            this.btnRetour.TabIndex = 17;
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // LANGAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 211);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.grBxNewLangage);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lstBxLangage);
            this.Name = "LANGAGE";
            this.Load += new System.EventHandler(this.Form13_Load);
            this.grBxNewLangage.ResumeLayout(false);
            this.grBxNewLangage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstBxLangage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.GroupBox grBxNewLangage;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNomLangage;
        private System.Windows.Forms.TextBox txtLangage;
        private System.Windows.Forms.Button btnRetour;
    }
}