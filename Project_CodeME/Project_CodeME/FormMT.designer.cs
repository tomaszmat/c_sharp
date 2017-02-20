namespace BlueHash
{
    partial class FormMT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUnhashedInfo = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelCheck = new System.Windows.Forms.Label();
            this.textBoxCheckHash = new System.Windows.Forms.TextBox();
            this.textBoxCheckUnHash = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelGeneratedHash = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGeneratedHash = new System.Windows.Forms.TextBox();
            this.buttonGenre = new System.Windows.Forms.Button();
            this.textBoxToGenre = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 299);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.labelUnhashedInfo);
            this.panel3.Controls.Add(this.buttonCheck);
            this.panel3.Controls.Add(this.labelCheck);
            this.panel3.Controls.Add(this.textBoxCheckHash);
            this.panel3.Controls.Add(this.textBoxCheckUnHash);
            this.panel3.Location = new System.Drawing.Point(3, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 140);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hashed";
            // 
            // labelUnhashedInfo
            // 
            this.labelUnhashedInfo.AutoSize = true;
            this.labelUnhashedInfo.Location = new System.Drawing.Point(9, 42);
            this.labelUnhashedInfo.Name = "labelUnhashedInfo";
            this.labelUnhashedInfo.Size = new System.Drawing.Size(68, 15);
            this.labelUnhashedInfo.TabIndex = 4;
            this.labelUnhashedInfo.Text = "Unhashed";
            // 
            // buttonCheck
            // 
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCheck.Location = new System.Drawing.Point(230, 94);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click_1);
            // 
            // labelCheck
            // 
            this.labelCheck.AutoSize = true;
            this.labelCheck.Location = new System.Drawing.Point(241, 21);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(49, 15);
            this.labelCheck.TabIndex = 2;
            this.labelCheck.Text = "Check:";
            // 
            // textBoxCheckHash
            // 
            this.textBoxCheckHash.Location = new System.Drawing.Point(106, 66);
            this.textBoxCheckHash.Name = "textBoxCheckHash";
            this.textBoxCheckHash.Size = new System.Drawing.Size(317, 22);
            this.textBoxCheckHash.TabIndex = 1;
            // 
            // textBoxCheckUnHash
            // 
            this.textBoxCheckUnHash.Location = new System.Drawing.Point(106, 39);
            this.textBoxCheckUnHash.Name = "textBoxCheckUnHash";
            this.textBoxCheckUnHash.Size = new System.Drawing.Size(317, 22);
            this.textBoxCheckUnHash.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelGeneratedHash);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxGeneratedHash);
            this.panel2.Controls.Add(this.buttonGenre);
            this.panel2.Controls.Add(this.textBoxToGenre);
            this.panel2.Controls.Add(this.labelGenre);
            this.panel2.Location = new System.Drawing.Point(3, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 132);
            this.panel2.TabIndex = 1;
            // 
            // labelGeneratedHash
            // 
            this.labelGeneratedHash.AutoSize = true;
            this.labelGeneratedHash.Location = new System.Drawing.Point(4, 106);
            this.labelGeneratedHash.Name = "labelGeneratedHash";
            this.labelGeneratedHash.Size = new System.Drawing.Size(70, 15);
            this.labelGeneratedHash.TabIndex = 5;
            this.labelGeneratedHash.Text = "Generated";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chars To Hash";
            // 
            // textBoxGeneratedHash
            // 
            this.textBoxGeneratedHash.Location = new System.Drawing.Point(106, 103);
            this.textBoxGeneratedHash.Name = "textBoxGeneratedHash";
            this.textBoxGeneratedHash.Size = new System.Drawing.Size(321, 22);
            this.textBoxGeneratedHash.TabIndex = 3;
            // 
            // buttonGenre
            // 
            this.buttonGenre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenre.Location = new System.Drawing.Point(230, 67);
            this.buttonGenre.Name = "buttonGenre";
            this.buttonGenre.Size = new System.Drawing.Size(75, 23);
            this.buttonGenre.TabIndex = 2;
            this.buttonGenre.Text = "Genre";
            this.buttonGenre.UseVisualStyleBackColor = true;
            this.buttonGenre.Click += new System.EventHandler(this.buttonGenre_Click_1);
            // 
            // textBoxToGenre
            // 
            this.textBoxToGenre.Location = new System.Drawing.Point(106, 39);
            this.textBoxToGenre.Name = "textBoxToGenre";
            this.textBoxToGenre.Size = new System.Drawing.Size(321, 22);
            this.textBoxToGenre.TabIndex = 1;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(241, 21);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(47, 15);
            this.labelGenre.TabIndex = 0;
            this.labelGenre.Text = "Genre:";
            // 
            // FormMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 299);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMT";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MT5";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUnhashedInfo;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelCheck;
        private System.Windows.Forms.TextBox textBoxCheckHash;
        private System.Windows.Forms.TextBox textBoxCheckUnHash;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelGeneratedHash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGeneratedHash;
        private System.Windows.Forms.Button buttonGenre;
        private System.Windows.Forms.TextBox textBoxToGenre;
        private System.Windows.Forms.Label labelGenre;
    }
}

