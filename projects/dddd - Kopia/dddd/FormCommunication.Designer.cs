namespace RadioTerminal
{
    partial class FormCommunication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommunication));
            this.listBoxRecived = new System.Windows.Forms.ListBox();
            this.comboBoxAmplifer = new System.Windows.Forms.ComboBox();
            this.radioButtonRadio = new System.Windows.Forms.RadioButton();
            this.radioButtonSettings = new System.Windows.Forms.RadioButton();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSetDef = new System.Windows.Forms.Button();
            this.labelState = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.comboBoxChannel = new System.Windows.Forms.ComboBox();
            this.labelChannel = new System.Windows.Forms.Label();
            this.labelPower = new System.Windows.Forms.Label();
            this.labelCounter = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelErrorStatus = new System.Windows.Forms.Label();
            this.panelRadio = new System.Windows.Forms.Panel();
            this.labelRecived = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelSend = new System.Windows.Forms.Panel();
            this.labelHistory = new System.Windows.Forms.Label();
            this.listBoxSended = new System.Windows.Forms.ListBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonSet = new System.Windows.Forms.Button();
            this.linkLabelMail = new System.Windows.Forms.LinkLabel();
            this.panelSettings.SuspendLayout();
            this.panelRadio.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxRecived
            // 
            this.listBoxRecived.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxRecived.FormattingEnabled = true;
            this.listBoxRecived.Location = new System.Drawing.Point(14, 34);
            this.listBoxRecived.Name = "listBoxRecived";
            this.listBoxRecived.Size = new System.Drawing.Size(168, 234);
            this.listBoxRecived.TabIndex = 0;
            // 
            // comboBoxAmplifer
            // 
            this.comboBoxAmplifer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAmplifer.FormattingEnabled = true;
            this.comboBoxAmplifer.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8 (default)"});
            this.comboBoxAmplifer.Location = new System.Drawing.Point(130, 43);
            this.comboBoxAmplifer.Name = "comboBoxAmplifer";
            this.comboBoxAmplifer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAmplifer.TabIndex = 2;
            // 
            // radioButtonRadio
            // 
            this.radioButtonRadio.AutoSize = true;
            this.radioButtonRadio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRadio.Location = new System.Drawing.Point(24, 15);
            this.radioButtonRadio.Name = "radioButtonRadio";
            this.radioButtonRadio.Size = new System.Drawing.Size(55, 16);
            this.radioButtonRadio.TabIndex = 3;
            this.radioButtonRadio.TabStop = true;
            this.radioButtonRadio.Text = "Radio";
            this.radioButtonRadio.UseVisualStyleBackColor = true;
            this.radioButtonRadio.CheckedChanged += new System.EventHandler(this.radioButtonRadio_CheckedChanged);
            // 
            // radioButtonSettings
            // 
            this.radioButtonSettings.AutoSize = true;
            this.radioButtonSettings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSettings.Location = new System.Drawing.Point(85, 15);
            this.radioButtonSettings.Name = "radioButtonSettings";
            this.radioButtonSettings.Size = new System.Drawing.Size(68, 16);
            this.radioButtonSettings.TabIndex = 4;
            this.radioButtonSettings.TabStop = true;
            this.radioButtonSettings.Text = "Settings";
            this.radioButtonSettings.UseVisualStyleBackColor = true;
            this.radioButtonSettings.CheckedChanged += new System.EventHandler(this.radioButtonSettings_CheckedChanged);
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelSettings.Controls.Add(this.buttonSet);
            this.panelSettings.Controls.Add(this.comboBox1);
            this.panelSettings.Controls.Add(this.label1);
            this.panelSettings.Controls.Add(this.buttonSetDef);
            this.panelSettings.Controls.Add(this.labelState);
            this.panelSettings.Controls.Add(this.comboBoxState);
            this.panelSettings.Controls.Add(this.comboBoxChannel);
            this.panelSettings.Controls.Add(this.labelChannel);
            this.panelSettings.Controls.Add(this.labelPower);
            this.panelSettings.Controls.Add(this.labelCounter);
            this.panelSettings.Controls.Add(this.buttonCheck);
            this.panelSettings.Controls.Add(this.labelErrorStatus);
            this.panelSettings.Controls.Add(this.comboBoxAmplifer);
            this.panelSettings.Location = new System.Drawing.Point(212, 133);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(262, 205);
            this.panelSettings.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "FU1 (more power saving mode)",
            "FU2 (power saving mode)",
            "FU3 (default)",
            "FU4 (ultra long distance)"});
            this.comboBox1.Location = new System.Drawing.Point(130, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Baudrate:";
            // 
            // buttonSetDef
            // 
            this.buttonSetDef.BackColor = System.Drawing.Color.White;
            this.buttonSetDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetDef.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetDef.Location = new System.Drawing.Point(13, 160);
            this.buttonSetDef.Name = "buttonSetDef";
            this.buttonSetDef.Size = new System.Drawing.Size(111, 23);
            this.buttonSetDef.TabIndex = 11;
            this.buttonSetDef.Text = "Set defaults";
            this.buttonSetDef.UseVisualStyleBackColor = false;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(59, 106);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(37, 12);
            this.labelState.TabIndex = 10;
            this.labelState.Text = "State:";
            // 
            // comboBoxState
            // 
            this.comboBoxState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "FU1 (more power saving mode)",
            "FU2 (power saving mode)",
            "FU3 (default)",
            "FU4 (ultra long distance)"});
            this.comboBoxState.Location = new System.Drawing.Point(130, 102);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(121, 21);
            this.comboBoxState.TabIndex = 9;
            // 
            // comboBoxChannel
            // 
            this.comboBoxChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxChannel.FormattingEnabled = true;
            this.comboBoxChannel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17"});
            this.comboBoxChannel.Location = new System.Drawing.Point(130, 73);
            this.comboBoxChannel.Name = "comboBoxChannel";
            this.comboBoxChannel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChannel.TabIndex = 8;
            // 
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChannel.Location = new System.Drawing.Point(42, 77);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(54, 12);
            this.labelChannel.TabIndex = 7;
            this.labelChannel.Text = "Channel:";
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPower.Location = new System.Drawing.Point(53, 47);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(43, 12);
            this.labelPower.TabIndex = 6;
            this.labelPower.Text = "Power:";
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCounter.Location = new System.Drawing.Point(102, 19);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(12, 12);
            this.labelCounter.TabIndex = 5;
            this.labelCounter.Text = "0";
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.White;
            this.buttonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheck.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.Location = new System.Drawing.Point(130, 14);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(121, 23);
            this.buttonCheck.TabIndex = 4;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // labelErrorStatus
            // 
            this.labelErrorStatus.AutoSize = true;
            this.labelErrorStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorStatus.Location = new System.Drawing.Point(21, 19);
            this.labelErrorStatus.Name = "labelErrorStatus";
            this.labelErrorStatus.Size = new System.Drawing.Size(75, 12);
            this.labelErrorStatus.TabIndex = 3;
            this.labelErrorStatus.Text = "Error Status:";
            // 
            // panelRadio
            // 
            this.panelRadio.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelRadio.Controls.Add(this.labelRecived);
            this.panelRadio.Controls.Add(this.button2);
            this.panelRadio.Controls.Add(this.listBoxRecived);
            this.panelRadio.Location = new System.Drawing.Point(11, 133);
            this.panelRadio.Name = "panelRadio";
            this.panelRadio.Size = new System.Drawing.Size(195, 354);
            this.panelRadio.TabIndex = 6;
            // 
            // labelRecived
            // 
            this.labelRecived.AutoSize = true;
            this.labelRecived.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecived.Location = new System.Drawing.Point(74, 14);
            this.labelRecived.Name = "labelRecived";
            this.labelRecived.Size = new System.Drawing.Size(53, 12);
            this.labelRecived.TabIndex = 12;
            this.labelRecived.Text = "Recived:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(14, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Save As..";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelMain.Controls.Add(this.buttonDisconnect);
            this.panelMain.Controls.Add(this.buttonReset);
            this.panelMain.Controls.Add(this.radioButtonRadio);
            this.panelMain.Controls.Add(this.radioButtonSettings);
            this.panelMain.Location = new System.Drawing.Point(11, 84);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(463, 43);
            this.panelMain.TabIndex = 7;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.White;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(204, 12);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(121, 23);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(35, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 66);
            this.panel3.TabIndex = 13;
            // 
            // panelSend
            // 
            this.panelSend.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelSend.Controls.Add(this.labelHistory);
            this.panelSend.Controls.Add(this.listBoxSended);
            this.panelSend.Controls.Add(this.textBoxSend);
            this.panelSend.Controls.Add(this.buttonSend);
            this.panelSend.Location = new System.Drawing.Point(212, 344);
            this.panelSend.Name = "panelSend";
            this.panelSend.Size = new System.Drawing.Size(262, 143);
            this.panelSend.TabIndex = 7;
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHistory.Location = new System.Drawing.Point(59, 37);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(47, 12);
            this.labelHistory.TabIndex = 14;
            this.labelHistory.Text = "History:";
            // 
            // listBoxSended
            // 
            this.listBoxSended.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSended.FormattingEnabled = true;
            this.listBoxSended.Location = new System.Drawing.Point(23, 65);
            this.listBoxSended.Name = "listBoxSended";
            this.listBoxSended.Size = new System.Drawing.Size(218, 65);
            this.listBoxSended.TabIndex = 13;
            // 
            // textBoxSend
            // 
            this.textBoxSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSend.Location = new System.Drawing.Point(23, 13);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(218, 13);
            this.textBoxSend.TabIndex = 13;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.White;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.Location = new System.Drawing.Point(142, 32);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(99, 23);
            this.buttonSend.TabIndex = 12;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.LightCoral;
            this.buttonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisconnect.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.Location = new System.Drawing.Point(331, 12);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(121, 23);
            this.buttonDisconnect.TabIndex = 16;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonSet
            // 
            this.buttonSet.BackColor = System.Drawing.Color.White;
            this.buttonSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSet.Location = new System.Drawing.Point(130, 160);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(121, 23);
            this.buttonSet.TabIndex = 14;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = false;
            // 
            // linkLabelMail
            // 
            this.linkLabelMail.AutoSize = true;
            this.linkLabelMail.Location = new System.Drawing.Point(325, 490);
            this.linkLabelMail.Name = "linkLabelMail";
            this.linkLabelMail.Size = new System.Drawing.Size(149, 13);
            this.linkLabelMail.TabIndex = 14;
            this.linkLabelMail.TabStop = true;
            this.linkLabelMail.Text = "t.matusiak@satrevolution.com";
            // 
            // FormCommunication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(491, 510);
            this.Controls.Add(this.linkLabelMail);
            this.Controls.Add(this.panelSend);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelRadio);
            this.Controls.Add(this.panelSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCommunication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatRevolution S.A. Radio Terminal 1.0";
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panelRadio.ResumeLayout(false);
            this.panelRadio.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelSend.ResumeLayout(false);
            this.panelSend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRecived;
        private System.Windows.Forms.ComboBox comboBoxAmplifer;
        private System.Windows.Forms.RadioButton radioButtonRadio;
        private System.Windows.Forms.RadioButton radioButtonSettings;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelRadio;
        private System.Windows.Forms.Label labelErrorStatus;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.ComboBox comboBoxChannel;
        private System.Windows.Forms.Label labelChannel;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.Button buttonSetDef;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelSend;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelRecived;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.ListBox listBoxSended;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.LinkLabel linkLabelMail;
    }
}