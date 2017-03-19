namespace genre
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonggg = new System.Windows.Forms.Button();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.buttonGen = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxChFTB = new System.Windows.Forms.TextBox();
            this.textBoxHashedText = new System.Windows.Forms.TextBox();
            this.radioButtonCheckFTB = new System.Windows.Forms.RadioButton();
            this.radioButtonChFWL = new System.Windows.Forms.RadioButton();
            this.buttonSource = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxChooseCode = new System.Windows.Forms.ComboBox();
            this.textBoxHash = new System.Windows.Forms.TextBox();
            this.textBoxToH = new System.Windows.Forms.TextBox();
            this.buttonHash = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "bluemanncode@outlook.com";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSave.Location = new System.Drawing.Point(252, 137);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(154, 27);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save History";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage3.Controls.Add(this.buttonggg);
            this.tabPage3.Controls.Add(this.textBoxLink);
            this.tabPage3.Controls.Add(this.buttonGen);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(412, 169);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Passwords Gens";
            // 
            // buttonggg
            // 
            this.buttonggg.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonggg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonggg.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonggg.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonggg.Location = new System.Drawing.Point(276, 58);
            this.buttonggg.Name = "buttonggg";
            this.buttonggg.Size = new System.Drawing.Size(113, 26);
            this.buttonggg.TabIndex = 2;
            this.buttonggg.Text = "Genre";
            this.buttonggg.UseVisualStyleBackColor = false;
            this.buttonggg.Click += new System.EventHandler(this.buttonggg_Click);
            // 
            // textBoxLink
            // 
            this.textBoxLink.Location = new System.Drawing.Point(15, 26);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(253, 23);
            this.textBoxLink.TabIndex = 1;
            // 
            // buttonGen
            // 
            this.buttonGen.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGen.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGen.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGen.Location = new System.Drawing.Point(276, 26);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(113, 26);
            this.buttonGen.TabIndex = 0;
            this.buttonGen.Text = "Load File";
            this.buttonGen.UseVisualStyleBackColor = false;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBoxChFTB);
            this.tabPage2.Controls.Add(this.textBoxHashedText);
            this.tabPage2.Controls.Add(this.radioButtonCheckFTB);
            this.tabPage2.Controls.Add(this.radioButtonChFWL);
            this.tabPage2.Controls.Add(this.buttonSource);
            this.tabPage2.Controls.Add(this.buttonCheck);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(412, 169);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Checking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "(only MD5)";
            // 
            // textBoxChFTB
            // 
            this.textBoxChFTB.Location = new System.Drawing.Point(6, 86);
            this.textBoxChFTB.Multiline = true;
            this.textBoxChFTB.Name = "textBoxChFTB";
            this.textBoxChFTB.Size = new System.Drawing.Size(220, 23);
            this.textBoxChFTB.TabIndex = 8;
            // 
            // textBoxHashedText
            // 
            this.textBoxHashedText.Location = new System.Drawing.Point(6, 6);
            this.textBoxHashedText.Multiline = true;
            this.textBoxHashedText.Name = "textBoxHashedText";
            this.textBoxHashedText.Size = new System.Drawing.Size(400, 48);
            this.textBoxHashedText.TabIndex = 4;
            // 
            // radioButtonCheckFTB
            // 
            this.radioButtonCheckFTB.AutoSize = true;
            this.radioButtonCheckFTB.Location = new System.Drawing.Point(6, 60);
            this.radioButtonCheckFTB.Name = "radioButtonCheckFTB";
            this.radioButtonCheckFTB.Size = new System.Drawing.Size(144, 19);
            this.radioButtonCheckFTB.TabIndex = 7;
            this.radioButtonCheckFTB.TabStop = true;
            this.radioButtonCheckFTB.Text = "Check from Text Box";
            this.radioButtonCheckFTB.UseVisualStyleBackColor = true;
            this.radioButtonCheckFTB.CheckedChanged += new System.EventHandler(this.radioButtonCheckFTB_CheckedChanged);
            // 
            // radioButtonChFWL
            // 
            this.radioButtonChFWL.AutoSize = true;
            this.radioButtonChFWL.Location = new System.Drawing.Point(232, 60);
            this.radioButtonChFWL.Name = "radioButtonChFWL";
            this.radioButtonChFWL.Size = new System.Drawing.Size(145, 19);
            this.radioButtonChFWL.TabIndex = 6;
            this.radioButtonChFWL.TabStop = true;
            this.radioButtonChFWL.Text = "Check with words list";
            this.radioButtonChFWL.UseVisualStyleBackColor = true;
            this.radioButtonChFWL.CheckedChanged += new System.EventHandler(this.radioButtonChFWL_CheckedChanged);
            // 
            // buttonSource
            // 
            this.buttonSource.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSource.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSource.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSource.Location = new System.Drawing.Point(232, 82);
            this.buttonSource.Name = "buttonSource";
            this.buttonSource.Size = new System.Drawing.Size(174, 28);
            this.buttonSource.TabIndex = 5;
            this.buttonSource.Text = "Source";
            this.buttonSource.UseVisualStyleBackColor = false;
            this.buttonSource.Click += new System.EventHandler(this.buttonSource_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCheck.Location = new System.Drawing.Point(142, 115);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(174, 28);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Controls.Add(this.comboBoxChooseCode);
            this.tabPage1.Controls.Add(this.textBoxHash);
            this.tabPage1.Controls.Add(this.textBoxToH);
            this.tabPage1.Controls.Add(this.buttonHash);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(412, 169);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hashing";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // comboBoxChooseCode
            // 
            this.comboBoxChooseCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxChooseCode.FormattingEnabled = true;
            this.comboBoxChooseCode.Items.AddRange(new object[] {
            "MD5",
            "SHA512",
            "SHA1",
            "SHA384",
            "SHA256"});
            this.comboBoxChooseCode.Location = new System.Drawing.Point(6, 42);
            this.comboBoxChooseCode.Name = "comboBoxChooseCode";
            this.comboBoxChooseCode.Size = new System.Drawing.Size(179, 23);
            this.comboBoxChooseCode.TabIndex = 8;
            this.comboBoxChooseCode.Text = "Coding Type";
            this.comboBoxChooseCode.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseCode_SelectedIndexChanged);
            // 
            // textBoxHash
            // 
            this.textBoxHash.Location = new System.Drawing.Point(6, 81);
            this.textBoxHash.Multiline = true;
            this.textBoxHash.Name = "textBoxHash";
            this.textBoxHash.Size = new System.Drawing.Size(400, 50);
            this.textBoxHash.TabIndex = 7;
            // 
            // textBoxToH
            // 
            this.textBoxToH.Location = new System.Drawing.Point(6, 6);
            this.textBoxToH.Multiline = true;
            this.textBoxToH.Name = "textBoxToH";
            this.textBoxToH.Size = new System.Drawing.Size(400, 30);
            this.textBoxToH.TabIndex = 6;
            this.textBoxToH.TextChanged += new System.EventHandler(this.textBoxToH_TextChanged);
            // 
            // buttonHash
            // 
            this.buttonHash.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHash.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonHash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHash.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHash.Location = new System.Drawing.Point(191, 42);
            this.buttonHash.Name = "buttonHash";
            this.buttonHash.Size = new System.Drawing.Size(215, 23);
            this.buttonHash.TabIndex = 5;
            this.buttonHash.Text = "Hash";
            this.buttonHash.UseVisualStyleBackColor = false;
            this.buttonHash.Click += new System.EventHandler(this.buttonHash_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 197);
            this.tabControl1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 236);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classic v1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonggg;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxChFTB;
        private System.Windows.Forms.TextBox textBoxHashedText;
        private System.Windows.Forms.RadioButton radioButtonCheckFTB;
        private System.Windows.Forms.RadioButton radioButtonChFWL;
        private System.Windows.Forms.Button buttonSource;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBoxChooseCode;
        private System.Windows.Forms.TextBox textBoxHash;
        private System.Windows.Forms.TextBox textBoxToH;
        private System.Windows.Forms.Button buttonHash;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

