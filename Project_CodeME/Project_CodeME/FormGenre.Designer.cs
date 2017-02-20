namespace Project_CodeME
{
    partial class FormGenre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGenre));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelExecute = new System.Windows.Forms.Label();
            this.groupBoxMBMD = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBoxGenreOrEquals = new System.Windows.Forms.GroupBox();
            this.radioButtonEquals = new System.Windows.Forms.RadioButton();
            this.radioButtonGenre = new System.Windows.Forms.RadioButton();
            this.groupBoxSelectMethod = new System.Windows.Forms.GroupBox();
            this.radioButtonMB5 = new System.Windows.Forms.RadioButton();
            this.radioButtonMD5 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxToGenre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonGuid = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelOptions = new System.Windows.Forms.Label();
            this.comboBoxAplha = new System.Windows.Forms.ComboBox();
            this.labelWithSpecialChars = new System.Windows.Forms.Label();
            this.labelHowLong = new System.Windows.Forms.Label();
            this.buttonGenre = new System.Windows.Forms.Button();
            this.labelMaxInfo = new System.Windows.Forms.Label();
            this.textBoxHowLong = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxGeneratedHash = new System.Windows.Forms.TextBox();
            this.labelYouAreLogged = new System.Windows.Forms.Label();
            this.labelShow = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxMBMD.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBoxGenreOrEquals.SuspendLayout();
            this.groupBoxSelectMethod.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 591);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.labelShow);
            this.panel2.Controls.Add(this.labelYouAreLogged);
            this.panel2.Controls.Add(this.labelExecute);
            this.panel2.Controls.Add(this.groupBoxMBMD);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBoxGeneratedHash);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 591);
            this.panel2.TabIndex = 1;
            // 
            // labelExecute
            // 
            this.labelExecute.AutoSize = true;
            this.labelExecute.Location = new System.Drawing.Point(12, 201);
            this.labelExecute.Name = "labelExecute";
            this.labelExecute.Size = new System.Drawing.Size(59, 15);
            this.labelExecute.TabIndex = 15;
            this.labelExecute.Text = "Execute:";
            // 
            // groupBoxMBMD
            // 
            this.groupBoxMBMD.Controls.Add(this.panel4);
            this.groupBoxMBMD.Location = new System.Drawing.Point(22, 243);
            this.groupBoxMBMD.Name = "groupBoxMBMD";
            this.groupBoxMBMD.Size = new System.Drawing.Size(524, 201);
            this.groupBoxMBMD.TabIndex = 14;
            this.groupBoxMBMD.TabStop = false;
            this.groupBoxMBMD.Text = "MD5/MB5";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.GhostWhite;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(3, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(518, 180);
            this.panel4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBoxGenreOrEquals);
            this.panel6.Controls.Add(this.groupBoxSelectMethod);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.textBoxToGenre);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(518, 180);
            this.panel6.TabIndex = 1;
            // 
            // groupBoxGenreOrEquals
            // 
            this.groupBoxGenreOrEquals.Controls.Add(this.radioButtonEquals);
            this.groupBoxGenreOrEquals.Controls.Add(this.radioButtonGenre);
            this.groupBoxGenreOrEquals.Location = new System.Drawing.Point(230, 50);
            this.groupBoxGenreOrEquals.Name = "groupBoxGenreOrEquals";
            this.groupBoxGenreOrEquals.Size = new System.Drawing.Size(200, 83);
            this.groupBoxGenreOrEquals.TabIndex = 7;
            this.groupBoxGenreOrEquals.TabStop = false;
            this.groupBoxGenreOrEquals.Text = "Genre or Equals";
            // 
            // radioButtonEquals
            // 
            this.radioButtonEquals.AutoSize = true;
            this.radioButtonEquals.Location = new System.Drawing.Point(27, 48);
            this.radioButtonEquals.Name = "radioButtonEquals";
            this.radioButtonEquals.Size = new System.Drawing.Size(65, 19);
            this.radioButtonEquals.TabIndex = 1;
            this.radioButtonEquals.TabStop = true;
            this.radioButtonEquals.Text = "Equals";
            this.radioButtonEquals.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenre
            // 
            this.radioButtonGenre.AutoSize = true;
            this.radioButtonGenre.Location = new System.Drawing.Point(27, 21);
            this.radioButtonGenre.Name = "radioButtonGenre";
            this.radioButtonGenre.Size = new System.Drawing.Size(61, 19);
            this.radioButtonGenre.TabIndex = 0;
            this.radioButtonGenre.TabStop = true;
            this.radioButtonGenre.Text = "Genre";
            this.radioButtonGenre.UseVisualStyleBackColor = true;
            // 
            // groupBoxSelectMethod
            // 
            this.groupBoxSelectMethod.Controls.Add(this.radioButtonMB5);
            this.groupBoxSelectMethod.Controls.Add(this.radioButtonMD5);
            this.groupBoxSelectMethod.Location = new System.Drawing.Point(18, 50);
            this.groupBoxSelectMethod.Name = "groupBoxSelectMethod";
            this.groupBoxSelectMethod.Size = new System.Drawing.Size(200, 83);
            this.groupBoxSelectMethod.TabIndex = 6;
            this.groupBoxSelectMethod.TabStop = false;
            this.groupBoxSelectMethod.Text = "Select Method";
            // 
            // radioButtonMB5
            // 
            this.radioButtonMB5.AutoSize = true;
            this.radioButtonMB5.Location = new System.Drawing.Point(26, 47);
            this.radioButtonMB5.Name = "radioButtonMB5";
            this.radioButtonMB5.Size = new System.Drawing.Size(50, 19);
            this.radioButtonMB5.TabIndex = 6;
            this.radioButtonMB5.TabStop = true;
            this.radioButtonMB5.Text = "MB5";
            this.radioButtonMB5.UseVisualStyleBackColor = true;
            // 
            // radioButtonMD5
            // 
            this.radioButtonMD5.AutoSize = true;
            this.radioButtonMD5.Location = new System.Drawing.Point(26, 21);
            this.radioButtonMD5.Name = "radioButtonMD5";
            this.radioButtonMD5.Size = new System.Drawing.Size(52, 19);
            this.radioButtonMD5.TabIndex = 5;
            this.radioButtonMD5.TabStop = true;
            this.radioButtonMD5.Text = "MD5";
            this.radioButtonMD5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chars To Hash";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(436, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Genre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxToGenre
            // 
            this.textBoxToGenre.Location = new System.Drawing.Point(109, 13);
            this.textBoxToGenre.Name = "textBoxToGenre";
            this.textBoxToGenre.Size = new System.Drawing.Size(321, 22);
            this.textBoxToGenre.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelInfo);
            this.groupBox2.Controls.Add(this.buttonGuid);
            this.groupBox2.Location = new System.Drawing.Point(12, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 144);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GUID";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(7, 22);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(135, 90);
            this.labelInfo.TabIndex = 12;
            this.labelInfo.Text = "GUID (or UUID) is an \r\nacronym \r\nfor \'Globally \r\nUnique Identifier\'\r\n (or \'Univer" +
    "sally\r\n Unique Identifier\'). ";
            // 
            // buttonGuid
            // 
            this.buttonGuid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGuid.Location = new System.Drawing.Point(52, 115);
            this.buttonGuid.Name = "buttonGuid";
            this.buttonGuid.Size = new System.Drawing.Size(97, 23);
            this.buttonGuid.TabIndex = 11;
            this.buttonGuid.Text = "GUID Genre";
            this.buttonGuid.UseVisualStyleBackColor = true;
            this.buttonGuid.Click += new System.EventHandler(this.buttonGuid_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelOptions);
            this.groupBox1.Controls.Add(this.comboBoxAplha);
            this.groupBox1.Controls.Add(this.labelWithSpecialChars);
            this.groupBox1.Controls.Add(this.labelHowLong);
            this.groupBox1.Controls.Add(this.buttonGenre);
            this.groupBox1.Controls.Add(this.labelMaxInfo);
            this.groupBox1.Controls.Add(this.textBoxHowLong);
            this.groupBox1.Location = new System.Drawing.Point(218, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 144);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Random";
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.Location = new System.Drawing.Point(158, 17);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(55, 15);
            this.labelOptions.TabIndex = 6;
            this.labelOptions.Text = "Options";
            // 
            // comboBoxAplha
            // 
            this.comboBoxAplha.FormattingEnabled = true;
            this.comboBoxAplha.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxAplha.Location = new System.Drawing.Point(132, 41);
            this.comboBoxAplha.Name = "comboBoxAplha";
            this.comboBoxAplha.Size = new System.Drawing.Size(121, 23);
            this.comboBoxAplha.TabIndex = 4;
            // 
            // labelWithSpecialChars
            // 
            this.labelWithSpecialChars.AutoSize = true;
            this.labelWithSpecialChars.Location = new System.Drawing.Point(6, 49);
            this.labelWithSpecialChars.Name = "labelWithSpecialChars";
            this.labelWithSpecialChars.Size = new System.Drawing.Size(125, 15);
            this.labelWithSpecialChars.TabIndex = 7;
            this.labelWithSpecialChars.Text = "With special chars?";
            // 
            // labelHowLong
            // 
            this.labelHowLong.AutoSize = true;
            this.labelHowLong.Location = new System.Drawing.Point(61, 71);
            this.labelHowLong.Name = "labelHowLong";
            this.labelHowLong.Size = new System.Drawing.Size(70, 15);
            this.labelHowLong.TabIndex = 9;
            this.labelHowLong.Text = "How long?";
            // 
            // buttonGenre
            // 
            this.buttonGenre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenre.Location = new System.Drawing.Point(112, 112);
            this.buttonGenre.Name = "buttonGenre";
            this.buttonGenre.Size = new System.Drawing.Size(141, 23);
            this.buttonGenre.TabIndex = 2;
            this.buttonGenre.Text = "Genre";
            this.buttonGenre.UseVisualStyleBackColor = true;
            this.buttonGenre.Click += new System.EventHandler(this.buttonGenre_Click);
            // 
            // labelMaxInfo
            // 
            this.labelMaxInfo.AutoSize = true;
            this.labelMaxInfo.Location = new System.Drawing.Point(182, 96);
            this.labelMaxInfo.Name = "labelMaxInfo";
            this.labelMaxInfo.Size = new System.Drawing.Size(71, 15);
            this.labelMaxInfo.TabIndex = 10;
            this.labelMaxInfo.Text = "( Max 128)";
            // 
            // textBoxHowLong
            // 
            this.textBoxHowLong.Location = new System.Drawing.Point(132, 68);
            this.textBoxHowLong.Name = "textBoxHowLong";
            this.textBoxHowLong.Size = new System.Drawing.Size(121, 22);
            this.textBoxHowLong.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(492, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 112);
            this.panel3.TabIndex = 5;
            // 
            // textBoxGeneratedHash
            // 
            this.textBoxGeneratedHash.Location = new System.Drawing.Point(79, 198);
            this.textBoxGeneratedHash.Name = "textBoxGeneratedHash";
            this.textBoxGeneratedHash.Size = new System.Drawing.Size(621, 22);
            this.textBoxGeneratedHash.TabIndex = 3;
            // 
            // labelYouAreLogged
            // 
            this.labelYouAreLogged.AutoSize = true;
            this.labelYouAreLogged.Location = new System.Drawing.Point(69, 491);
            this.labelYouAreLogged.Name = "labelYouAreLogged";
            this.labelYouAreLogged.Size = new System.Drawing.Size(121, 15);
            this.labelYouAreLogged.TabIndex = 16;
            this.labelYouAreLogged.Text = "You are logged as:";
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Location = new System.Drawing.Point(196, 491);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(121, 15);
            this.labelShow.TabIndex = 17;
            this.labelShow.Text = "You are logged as:";
            // 
            // FormGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 591);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generator of Your own pass";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxMBMD.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBoxGenreOrEquals.ResumeLayout(false);
            this.groupBoxGenreOrEquals.PerformLayout();
            this.groupBoxSelectMethod.ResumeLayout(false);
            this.groupBoxSelectMethod.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxAplha;
        private System.Windows.Forms.TextBox textBoxGeneratedHash;
        private System.Windows.Forms.Button buttonGenre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelOptions;
        private System.Windows.Forms.Label labelMaxInfo;
        private System.Windows.Forms.Label labelHowLong;
        private System.Windows.Forms.TextBox textBoxHowLong;
        private System.Windows.Forms.Label labelWithSpecialChars;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonGuid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelExecute;
        private System.Windows.Forms.GroupBox groupBoxMBMD;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBoxGenreOrEquals;
        private System.Windows.Forms.RadioButton radioButtonEquals;
        private System.Windows.Forms.RadioButton radioButtonGenre;
        private System.Windows.Forms.GroupBox groupBoxSelectMethod;
        private System.Windows.Forms.RadioButton radioButtonMB5;
        private System.Windows.Forms.RadioButton radioButtonMD5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxToGenre;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Label labelYouAreLogged;
    }
}