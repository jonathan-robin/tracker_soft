namespace track3r
{
    partial class SAVELANGAGE
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rchTxtProbleme = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rchTxtDescription = new System.Windows.Forms.RichTextBox();
            this.rchTxtLien = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rchTxtSource = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(437, 336);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(56, 42);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(365, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 42);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "DESCRIPTION";
            // 
            // rchTxtProbleme
            // 
            this.rchTxtProbleme.Location = new System.Drawing.Point(12, 28);
            this.rchTxtProbleme.Name = "rchTxtProbleme";
            this.rchTxtProbleme.Size = new System.Drawing.Size(409, 26);
            this.rchTxtProbleme.TabIndex = 8;
            this.rchTxtProbleme.Text = "";
            this.rchTxtProbleme.TextChanged += new System.EventHandler(this.rchTxtProbleme_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "PROBLEMES";
            // 
            // rchTxtDescription
            // 
            this.rchTxtDescription.Location = new System.Drawing.Point(15, 187);
            this.rchTxtDescription.Name = "rchTxtDescription";
            this.rchTxtDescription.Size = new System.Drawing.Size(484, 144);
            this.rchTxtDescription.TabIndex = 6;
            this.rchTxtDescription.Text = "";
            this.rchTxtDescription.TextChanged += new System.EventHandler(this.rchTxtDescription_TextChanged);
            // 
            // rchTxtLien
            // 
            this.rchTxtLien.Location = new System.Drawing.Point(12, 126);
            this.rchTxtLien.Name = "rchTxtLien";
            this.rchTxtLien.Size = new System.Drawing.Size(409, 35);
            this.rchTxtLien.TabIndex = 15;
            this.rchTxtLien.Text = "";
            this.rchTxtLien.TextChanged += new System.EventHandler(this.rchTxtLien_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "LIEN";
            // 
            // rchTxtSource
            // 
            this.rchTxtSource.Location = new System.Drawing.Point(12, 79);
            this.rchTxtSource.Name = "rchTxtSource";
            this.rchTxtSource.Size = new System.Drawing.Size(409, 26);
            this.rchTxtSource.TabIndex = 17;
            this.rchTxtSource.Text = "";
            this.rchTxtSource.TextChanged += new System.EventHandler(this.rchTxtSource_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "SOURCE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SAVELANGAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 398);
            this.Controls.Add(this.rchTxtSource);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rchTxtLien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rchTxtProbleme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rchTxtDescription);
            this.Name = "SAVELANGAGE";
            this.Text = "SAVELANGAGE";
            this.Load += new System.EventHandler(this.SAVELANGAGE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchTxtProbleme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchTxtDescription;
        private System.Windows.Forms.RichTextBox rchTxtLien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rchTxtSource;
        private System.Windows.Forms.Label label3;
    }
}