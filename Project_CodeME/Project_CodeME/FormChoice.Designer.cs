namespace Project_CodeME
{
    partial class FormChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChoice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonMt5 = new System.Windows.Forms.Button();
            this.buttonMd5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonMt5);
            this.panel1.Controls.Add(this.buttonMd5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 165);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(47, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Genre your own Pass";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonGenre_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(246, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 113);
            this.panel2.TabIndex = 4;
            // 
            // buttonMt5
            // 
            this.buttonMt5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonMt5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonMt5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMt5.Location = new System.Drawing.Point(47, 69);
            this.buttonMt5.Name = "buttonMt5";
            this.buttonMt5.Size = new System.Drawing.Size(154, 23);
            this.buttonMt5.TabIndex = 1;
            this.buttonMt5.Text = "MT5";
            this.buttonMt5.UseVisualStyleBackColor = true;
            this.buttonMt5.Click += new System.EventHandler(this.buttonMt5_Click);
            // 
            // buttonMd5
            // 
            this.buttonMd5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.buttonMd5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonMd5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMd5.Location = new System.Drawing.Point(47, 24);
            this.buttonMd5.Name = "buttonMd5";
            this.buttonMd5.Size = new System.Drawing.Size(154, 23);
            this.buttonMd5.TabIndex = 0;
            this.buttonMd5.Text = "MD5";
            this.buttonMd5.UseVisualStyleBackColor = true;
            this.buttonMd5.Click += new System.EventHandler(this.buttonMd5_Click);
            // 
            // FormChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 165);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeME";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMt5;
        private System.Windows.Forms.Button buttonMd5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}

