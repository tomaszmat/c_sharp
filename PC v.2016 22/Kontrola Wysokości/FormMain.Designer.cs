namespace control
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxConnect = new System.Windows.Forms.GroupBox();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.buttonDiscon = new System.Windows.Forms.Button();
            this.buttonCon = new System.Windows.Forms.Button();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.labelBaud = new System.Windows.Forms.Label();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.buttonCalibrate = new System.Windows.Forms.Button();
            this.buttonServo = new System.Windows.Forms.Button();
            this.labelCm = new System.Windows.Forms.Label();
            this.comboBoxHigh = new System.Windows.Forms.ComboBox();
            this.labelSortBy = new System.Windows.Forms.Label();
            this.buttonChangeWithAccept = new System.Windows.Forms.Button();
            this.checkBoxToCheck = new System.Windows.Forms.CheckBox();
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.buttonClean = new System.Windows.Forms.Button();
            this.listBoxTest = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonCom = new System.Windows.Forms.Button();
            this.groupBoxConnect.SuspendLayout();
            this.groupBoxParameters.SuspendLayout();
            this.groupBoxSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConnect
            // 
            this.groupBoxConnect.Controls.Add(this.buttonCom);
            this.groupBoxConnect.Controls.Add(this.comboBoxBaud);
            this.groupBoxConnect.Controls.Add(this.buttonDiscon);
            this.groupBoxConnect.Controls.Add(this.buttonCon);
            this.groupBoxConnect.Controls.Add(this.comboBoxCOM);
            this.groupBoxConnect.Controls.Add(this.labelBaud);
            this.groupBoxConnect.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConnect.Name = "groupBoxConnect";
            this.groupBoxConnect.Size = new System.Drawing.Size(234, 148);
            this.groupBoxConnect.TabIndex = 8;
            this.groupBoxConnect.TabStop = false;
            this.groupBoxConnect.Text = "Połączenie";
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(65, 22);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(163, 21);
            this.comboBoxBaud.TabIndex = 2;
            // 
            // buttonDiscon
            // 
            this.buttonDiscon.Location = new System.Drawing.Point(6, 109);
            this.buttonDiscon.Name = "buttonDiscon";
            this.buttonDiscon.Size = new System.Drawing.Size(222, 23);
            this.buttonDiscon.TabIndex = 1;
            this.buttonDiscon.Text = "Rozłącz";
            this.buttonDiscon.UseVisualStyleBackColor = true;
            this.buttonDiscon.Click += new System.EventHandler(this.buttonDiscon_Click_1);
            // 
            // buttonCon
            // 
            this.buttonCon.Location = new System.Drawing.Point(6, 80);
            this.buttonCon.Name = "buttonCon";
            this.buttonCon.Size = new System.Drawing.Size(222, 23);
            this.buttonCon.TabIndex = 0;
            this.buttonCon.Text = "Połącz";
            this.buttonCon.UseVisualStyleBackColor = true;
            this.buttonCon.Click += new System.EventHandler(this.buttonCon_Click_1);
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(65, 49);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(163, 21);
            this.comboBoxCOM.TabIndex = 3;
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Location = new System.Drawing.Point(9, 25);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(50, 13);
            this.labelBaud.TabIndex = 4;
            this.labelBaud.Text = "Baudrate";
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.buttonCalibrate);
            this.groupBoxParameters.Controls.Add(this.buttonServo);
            this.groupBoxParameters.Controls.Add(this.buttonChangeWithAccept);
            this.groupBoxParameters.Controls.Add(this.labelCm);
            this.groupBoxParameters.Controls.Add(this.comboBoxHigh);
            this.groupBoxParameters.Controls.Add(this.labelSortBy);
            this.groupBoxParameters.Controls.Add(this.checkBoxToCheck);
            this.groupBoxParameters.Location = new System.Drawing.Point(252, 12);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(235, 181);
            this.groupBoxParameters.TabIndex = 9;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Parametry selekcji";
            // 
            // buttonCalibrate
            // 
            this.buttonCalibrate.Location = new System.Drawing.Point(7, 154);
            this.buttonCalibrate.Name = "buttonCalibrate";
            this.buttonCalibrate.Size = new System.Drawing.Size(222, 23);
            this.buttonCalibrate.TabIndex = 6;
            this.buttonCalibrate.Text = "Kalibracja HC-SR04";
            this.buttonCalibrate.UseVisualStyleBackColor = true;
            this.buttonCalibrate.Click += new System.EventHandler(this.buttonCalibrate_Click);
            // 
            // buttonServo
            // 
            this.buttonServo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonServo.Location = new System.Drawing.Point(7, 124);
            this.buttonServo.Name = "buttonServo";
            this.buttonServo.Size = new System.Drawing.Size(222, 23);
            this.buttonServo.TabIndex = 5;
            this.buttonServo.Text = "Włącz serwo";
            this.buttonServo.UseVisualStyleBackColor = true;
            this.buttonServo.Click += new System.EventHandler(this.buttonServo_Click);
            // 
            // labelCm
            // 
            this.labelCm.AutoSize = true;
            this.labelCm.Location = new System.Drawing.Point(16, 52);
            this.labelCm.Name = "labelCm";
            this.labelCm.Size = new System.Drawing.Size(23, 13);
            this.labelCm.TabIndex = 4;
            this.labelCm.Text = "X =";
            // 
            // comboBoxHigh
            // 
            this.comboBoxHigh.FormattingEnabled = true;
            this.comboBoxHigh.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "0"});
            this.comboBoxHigh.Location = new System.Drawing.Point(45, 49);
            this.comboBoxHigh.Name = "comboBoxHigh";
            this.comboBoxHigh.Size = new System.Drawing.Size(184, 21);
            this.comboBoxHigh.TabIndex = 3;
            // 
            // labelSortBy
            // 
            this.labelSortBy.AutoSize = true;
            this.labelSortBy.Location = new System.Drawing.Point(30, 30);
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(177, 13);
            this.labelSortBy.TabIndex = 2;
            this.labelSortBy.Text = "Sortuj większe lub równe dla  X [cm]";
            // 
            // buttonChangeWithAccept
            // 
            this.buttonChangeWithAccept.Location = new System.Drawing.Point(103, 86);
            this.buttonChangeWithAccept.Name = "buttonChangeWithAccept";
            this.buttonChangeWithAccept.Size = new System.Drawing.Size(126, 24);
            this.buttonChangeWithAccept.TabIndex = 1;
            this.buttonChangeWithAccept.Text = "Prześlij";
            this.buttonChangeWithAccept.UseVisualStyleBackColor = true;
            this.buttonChangeWithAccept.Click += new System.EventHandler(this.buttonChangeWithAccept_Click);
            // 
            // checkBoxToCheck
            // 
            this.checkBoxToCheck.AutoSize = true;
            this.checkBoxToCheck.Location = new System.Drawing.Point(7, 91);
            this.checkBoxToCheck.Name = "checkBoxToCheck";
            this.checkBoxToCheck.Size = new System.Drawing.Size(72, 17);
            this.checkBoxToCheck.TabIndex = 0;
            this.checkBoxToCheck.Text = "Potwierdź";
            this.checkBoxToCheck.UseVisualStyleBackColor = true;
            this.checkBoxToCheck.CheckedChanged += new System.EventHandler(this.checkBoxToCheck_CheckedChanged);
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.Controls.Add(this.buttonClean);
            this.groupBoxSort.Controls.Add(this.listBoxTest);
            this.groupBoxSort.Location = new System.Drawing.Point(493, 13);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Size = new System.Drawing.Size(256, 209);
            this.groupBoxSort.TabIndex = 10;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Odbierane dane:";
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(121, 19);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(129, 23);
            this.buttonClean.TabIndex = 8;
            this.buttonClean.Text = "Wyczyść";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // listBoxTest
            // 
            this.listBoxTest.FormattingEnabled = true;
            this.listBoxTest.Location = new System.Drawing.Point(6, 19);
            this.listBoxTest.Name = "listBoxTest";
            this.listBoxTest.Size = new System.Drawing.Size(109, 186);
            this.listBoxTest.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tomasz Matusiak. Michał Sobczyszak. Tomasz Barnaś.";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Lime;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(252, 199);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(234, 23);
            this.buttonStart.TabIndex = 13;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Red;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStop.Location = new System.Drawing.Point(13, 169);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(234, 53);
            this.buttonStop.TabIndex = 14;
            this.buttonStop.Text = "STOP";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonCom
            // 
            this.buttonCom.Location = new System.Drawing.Point(6, 49);
            this.buttonCom.Name = "buttonCom";
            this.buttonCom.Size = new System.Drawing.Size(53, 23);
            this.buttonCom.TabIndex = 7;
            this.buttonCom.Text = "COM";
            this.buttonCom.UseVisualStyleBackColor = true;
            this.buttonCom.Click += new System.EventHandler(this.buttonCom_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 247);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxSort);
            this.Controls.Add(this.groupBoxParameters);
            this.Controls.Add(this.groupBoxConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrola wysokości";
            this.groupBoxConnect.ResumeLayout(false);
            this.groupBoxConnect.PerformLayout();
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            this.groupBoxSort.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConnect;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Button buttonDiscon;
        private System.Windows.Forms.Button buttonCon;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonChangeWithAccept;
        private System.Windows.Forms.CheckBox checkBoxToCheck;
        private System.Windows.Forms.Label labelCm;
        private System.Windows.Forms.ComboBox comboBoxHigh;
        private System.Windows.Forms.Label labelSortBy;
        private System.Windows.Forms.ListBox listBoxTest;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonCalibrate;
        private System.Windows.Forms.Button buttonServo;
        private System.Windows.Forms.Button buttonCom;
    }
}

