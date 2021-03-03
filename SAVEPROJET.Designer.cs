namespace track3r
{
    partial class SAVEPROJET
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
            this.rchTxtCommentaires = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rchTxtObjectifs = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchTxtCommentaires
            // 
            this.rchTxtCommentaires.Location = new System.Drawing.Point(15, 118);
            this.rchTxtCommentaires.Name = "rchTxtCommentaires";
            this.rchTxtCommentaires.Size = new System.Drawing.Size(484, 144);
            this.rchTxtCommentaires.TabIndex = 0;
            this.rchTxtCommentaires.Text = "";
            this.rchTxtCommentaires.TextChanged += new System.EventHandler(this.rchTxtCommentaires_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "OBJECTIFS VISES ";
            // 
            // rchTxtObjectifs
            // 
            this.rchTxtObjectifs.Location = new System.Drawing.Point(12, 40);
            this.rchTxtObjectifs.Name = "rchTxtObjectifs";
            this.rchTxtObjectifs.Size = new System.Drawing.Size(481, 47);
            this.rchTxtObjectifs.TabIndex = 2;
            this.rchTxtObjectifs.Text = "";
            this.rchTxtObjectifs.TextChanged += new System.EventHandler(this.rchTxtObjectifs_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "COMMENTAIRES";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(365, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(437, 271);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(56, 42);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SAVEPROJET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 325);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rchTxtObjectifs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rchTxtCommentaires);
            this.Name = "SAVEPROJET";
            this.Load += new System.EventHandler(this.SAVEPROJET_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtCommentaires;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchTxtObjectifs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
    }
}