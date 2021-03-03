namespace track3r
{
    partial class GAME
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
            this.btnAOE = new System.Windows.Forms.Button();
            this.btnHS = new System.Windows.Forms.Button();
            this.btnTBC = new System.Windows.Forms.Button();
            this.btnshadowlands = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.BackgroundImage = global::track3r.Properties.Resources.az;
            this.btnRetour.Location = new System.Drawing.Point(40, 227);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(104, 97);
            this.btnRetour.TabIndex = 9;
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnAOE
            // 
            this.btnAOE.BackgroundImage = global::track3r.Properties.Resources.AoE_Definitive_Edition;
            this.btnAOE.Location = new System.Drawing.Point(260, 120);
            this.btnAOE.Name = "btnAOE";
            this.btnAOE.Size = new System.Drawing.Size(218, 162);
            this.btnAOE.TabIndex = 3;
            this.btnAOE.UseVisualStyleBackColor = true;
            this.btnAOE.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnHS
            // 
            this.btnHS.BackgroundImage = global::track3r.Properties.Resources.hs;
            this.btnHS.Location = new System.Drawing.Point(12, 120);
            this.btnHS.Name = "btnHS";
            this.btnHS.Size = new System.Drawing.Size(218, 101);
            this.btnHS.TabIndex = 2;
            this.btnHS.UseVisualStyleBackColor = true;
            this.btnHS.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTBC
            // 
            this.btnTBC.BackgroundImage = global::track3r.Properties.Resources.tbcimage;
            this.btnTBC.Location = new System.Drawing.Point(260, 12);
            this.btnTBC.Name = "btnTBC";
            this.btnTBC.Size = new System.Drawing.Size(218, 101);
            this.btnTBC.TabIndex = 1;
            this.btnTBC.UseVisualStyleBackColor = true;
            this.btnTBC.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnshadowlands
            // 
            this.btnshadowlands.BackgroundImage = global::track3r.Properties.Resources.shadowlands;
            this.btnshadowlands.Location = new System.Drawing.Point(12, 12);
            this.btnshadowlands.Name = "btnshadowlands";
            this.btnshadowlands.Size = new System.Drawing.Size(218, 101);
            this.btnshadowlands.TabIndex = 0;
            this.btnshadowlands.UseVisualStyleBackColor = true;
            this.btnshadowlands.Click += new System.EventHandler(this.button1_Click);
            // 
            // GAME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 330);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAOE);
            this.Controls.Add(this.btnHS);
            this.Controls.Add(this.btnTBC);
            this.Controls.Add(this.btnshadowlands);
            this.Name = "GAME";
            this.Text = "GAME";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnshadowlands;
        private System.Windows.Forms.Button btnTBC;
        private System.Windows.Forms.Button btnHS;
        private System.Windows.Forms.Button btnAOE;
        private System.Windows.Forms.Button btnRetour;
    }
}