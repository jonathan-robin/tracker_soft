namespace track3r
{
    partial class LEAVE
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
            this.gpbLeave = new System.Windows.Forms.GroupBox();
            this.btnOui = new System.Windows.Forms.Button();
            this.btnNon = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gpbLeave.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbLeave
            // 
            this.gpbLeave.Controls.Add(this.richTextBox1);
            this.gpbLeave.Controls.Add(this.btnNon);
            this.gpbLeave.Controls.Add(this.btnOui);
            this.gpbLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gpbLeave.Location = new System.Drawing.Point(37, 23);
            this.gpbLeave.Name = "gpbLeave";
            this.gpbLeave.Size = new System.Drawing.Size(283, 143);
            this.gpbLeave.TabIndex = 1;
            this.gpbLeave.TabStop = false;
            this.gpbLeave.Text = "Attention ! ";
            // 
            // btnOui
            // 
            this.btnOui.Location = new System.Drawing.Point(47, 91);
            this.btnOui.Name = "btnOui";
            this.btnOui.Size = new System.Drawing.Size(73, 34);
            this.btnOui.TabIndex = 1;
            this.btnOui.Text = "Oui";
            this.btnOui.UseVisualStyleBackColor = true;
            this.btnOui.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNon
            // 
            this.btnNon.Location = new System.Drawing.Point(155, 91);
            this.btnNon.Name = "btnNon";
            this.btnNon.Size = new System.Drawing.Size(73, 34);
            this.btnNon.TabIndex = 2;
            this.btnNon.Text = "Non";
            this.btnNon.UseVisualStyleBackColor = true;
            this.btnNon.Click += new System.EventHandler(this.btnNon_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(221, 50);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Souhaitez-vous annuler la session ? ";
            // 
            // LEAVE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 178);
            this.Controls.Add(this.gpbLeave);
            this.Name = "LEAVE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TRACK3R";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.gpbLeave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbLeave;
        private System.Windows.Forms.Button btnNon;
        private System.Windows.Forms.Button btnOui;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}