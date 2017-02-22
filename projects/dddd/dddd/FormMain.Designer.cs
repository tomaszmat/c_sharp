namespace dddd
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxCurrent = new System.Windows.Forms.TextBox();
            this.textBoxVoltage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelValues = new System.Windows.Forms.Panel();
            this.buttonChangeFreq = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.labelFreq = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCurMid = new System.Windows.Forms.TextBox();
            this.textBoxPowMid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVolMid = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonOpenExcel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.panelSets = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDiscon = new System.Windows.Forms.Button();
            this.zedGraphControlGraph = new ZedGraph.ZedGraphControl();
            this.zedGraphControlGraph2 = new ZedGraph.ZedGraphControl();
            this.zedGraphControlGraph3 = new ZedGraph.ZedGraphControl();
            this.timerGraph = new System.Windows.Forms.Timer(this.components);
            this.panelValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelSets.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(4, 12);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(139, 21);
            this.comboBoxPorts.TabIndex = 0;
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConnect.Font = new System.Drawing.Font("Agency FB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonConnect.Location = new System.Drawing.Point(3, 39);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(208, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Połącz";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxCurrent
            // 
            this.textBoxCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCurrent.Location = new System.Drawing.Point(114, 53);
            this.textBoxCurrent.Name = "textBoxCurrent";
            this.textBoxCurrent.Size = new System.Drawing.Size(100, 21);
            this.textBoxCurrent.TabIndex = 2;
            // 
            // textBoxVoltage
            // 
            this.textBoxVoltage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVoltage.Location = new System.Drawing.Point(114, 9);
            this.textBoxVoltage.Name = "textBoxVoltage";
            this.textBoxVoltage.Size = new System.Drawing.Size(100, 21);
            this.textBoxVoltage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Napięcie [V]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prąd [A]";
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTemp.Location = new System.Drawing.Point(114, 163);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.Size = new System.Drawing.Size(100, 21);
            this.textBoxTemp.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Temperatura [C]";
            // 
            // panelValues
            // 
            this.panelValues.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelValues.Controls.Add(this.textBoxTemp);
            this.panelValues.Controls.Add(this.buttonChangeFreq);
            this.panelValues.Controls.Add(this.label3);
            this.panelValues.Controls.Add(this.label5);
            this.panelValues.Controls.Add(this.numericUpDown2);
            this.panelValues.Controls.Add(this.labelFreq);
            this.panelValues.Controls.Add(this.label7);
            this.panelValues.Controls.Add(this.textBoxCurMid);
            this.panelValues.Controls.Add(this.textBoxPowMid);
            this.panelValues.Controls.Add(this.label8);
            this.panelValues.Controls.Add(this.textBoxPower);
            this.panelValues.Controls.Add(this.label9);
            this.panelValues.Controls.Add(this.label4);
            this.panelValues.Controls.Add(this.textBoxVoltage);
            this.panelValues.Controls.Add(this.label1);
            this.panelValues.Controls.Add(this.textBoxVolMid);
            this.panelValues.Controls.Add(this.textBoxCurrent);
            this.panelValues.Controls.Add(this.label2);
            this.panelValues.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelValues.Location = new System.Drawing.Point(666, 294);
            this.panelValues.Name = "panelValues";
            this.panelValues.Size = new System.Drawing.Size(217, 238);
            this.panelValues.TabIndex = 8;
            // 
            // buttonChangeFreq
            // 
            this.buttonChangeFreq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChangeFreq.Location = new System.Drawing.Point(173, 141);
            this.buttonChangeFreq.Name = "buttonChangeFreq";
            this.buttonChangeFreq.Size = new System.Drawing.Size(39, 21);
            this.buttonChangeFreq.TabIndex = 20;
            this.buttonChangeFreq.Text = "OK";
            this.buttonChangeFreq.UseVisualStyleBackColor = true;
            this.buttonChangeFreq.Click += new System.EventHandler(this.buttonChangeFreq_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("High Tower Text", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Autor: Tomasz Matusiak";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.Location = new System.Drawing.Point(114, 141);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(55, 21);
            this.numericUpDown2.TabIndex = 20;
            // 
            // labelFreq
            // 
            this.labelFreq.AutoSize = true;
            this.labelFreq.Location = new System.Drawing.Point(8, 144);
            this.labelFreq.Name = "labelFreq";
            this.labelFreq.Size = new System.Drawing.Size(105, 14);
            this.labelFreq.TabIndex = 16;
            this.labelFreq.Text = "Próbkowanie [ms]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "Moc średnia[W]";
            // 
            // textBoxCurMid
            // 
            this.textBoxCurMid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCurMid.Location = new System.Drawing.Point(114, 75);
            this.textBoxCurMid.Name = "textBoxCurMid";
            this.textBoxCurMid.Size = new System.Drawing.Size(100, 21);
            this.textBoxCurMid.TabIndex = 12;
            // 
            // textBoxPowMid
            // 
            this.textBoxPowMid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPowMid.Location = new System.Drawing.Point(114, 119);
            this.textBoxPowMid.Name = "textBoxPowMid";
            this.textBoxPowMid.Size = new System.Drawing.Size(100, 21);
            this.textBoxPowMid.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 14);
            this.label8.TabIndex = 14;
            this.label8.Text = "Prąd średni [A]";
            // 
            // textBoxPower
            // 
            this.textBoxPower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPower.Location = new System.Drawing.Point(114, 97);
            this.textBoxPower.Name = "textBoxPower";
            this.textBoxPower.Size = new System.Drawing.Size(100, 21);
            this.textBoxPower.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 14);
            this.label9.TabIndex = 15;
            this.label9.Text = "Napięcie średnie [V]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Moc [W]";
            // 
            // textBoxVolMid
            // 
            this.textBoxVolMid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVolMid.Location = new System.Drawing.Point(114, 31);
            this.textBoxVolMid.Name = "textBoxVolMid";
            this.textBoxVolMid.Size = new System.Drawing.Size(100, 21);
            this.textBoxVolMid.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Location = new System.Drawing.Point(667, 553);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 86);
            this.panel2.TabIndex = 9;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(14, 41);
            this.trackBar1.Maximum = 9;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(197, 42);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelButtons.Controls.Add(this.buttonOpenExcel);
            this.panelButtons.Controls.Add(this.button1);
            this.panelButtons.Controls.Add(this.buttonClear);
            this.panelButtons.Controls.Add(this.buttonShow);
            this.panelButtons.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelButtons.Location = new System.Drawing.Point(667, 158);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(216, 117);
            this.panelButtons.TabIndex = 10;
            // 
            // buttonOpenExcel
            // 
            this.buttonOpenExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenExcel.Location = new System.Drawing.Point(4, 3);
            this.buttonOpenExcel.Name = "buttonOpenExcel";
            this.buttonOpenExcel.Size = new System.Drawing.Size(209, 23);
            this.buttonOpenExcel.TabIndex = 14;
            this.buttonOpenExcel.Text = "Otwórz wyniki w Excel";
            this.buttonOpenExcel.UseVisualStyleBackColor = true;
            this.buttonOpenExcel.Click += new System.EventHandler(this.buttonOpenExcel_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(4, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Wyczyść dane";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Location = new System.Drawing.Point(4, 32);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(208, 23);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Wyczyść wykresy";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShow.Location = new System.Drawing.Point(4, 90);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(208, 23);
            this.buttonShow.TabIndex = 15;
            this.buttonShow.Text = "Pokaż wykresy";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // panelSets
            // 
            this.panelSets.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelSets.Controls.Add(this.buttonRefresh);
            this.panelSets.Controls.Add(this.buttonDiscon);
            this.panelSets.Controls.Add(this.comboBoxPorts);
            this.panelSets.Controls.Add(this.buttonConnect);
            this.panelSets.Location = new System.Drawing.Point(667, 41);
            this.panelSets.Name = "panelSets";
            this.panelSets.Size = new System.Drawing.Size(216, 93);
            this.panelSets.TabIndex = 11;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefresh.Location = new System.Drawing.Point(149, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(60, 21);
            this.buttonRefresh.TabIndex = 20;
            this.buttonRefresh.Text = "RF";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonDiscon
            // 
            this.buttonDiscon.BackColor = System.Drawing.Color.Brown;
            this.buttonDiscon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDiscon.Font = new System.Drawing.Font("Agency FB", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDiscon.Location = new System.Drawing.Point(3, 67);
            this.buttonDiscon.Name = "buttonDiscon";
            this.buttonDiscon.Size = new System.Drawing.Size(208, 23);
            this.buttonDiscon.TabIndex = 2;
            this.buttonDiscon.Text = "Rozłącz";
            this.buttonDiscon.UseVisualStyleBackColor = false;
            this.buttonDiscon.Click += new System.EventHandler(this.buttonDiscon_Click);
            // 
            // zedGraphControlGraph
            // 
            this.zedGraphControlGraph.Location = new System.Drawing.Point(6, 227);
            this.zedGraphControlGraph.Name = "zedGraphControlGraph";
            this.zedGraphControlGraph.Size = new System.Drawing.Size(654, 230);
            this.zedGraphControlGraph.TabIndex = 16;
            // 
            // zedGraphControlGraph2
            // 
            this.zedGraphControlGraph2.Location = new System.Drawing.Point(6, 450);
            this.zedGraphControlGraph2.Name = "zedGraphControlGraph2";
            this.zedGraphControlGraph2.Size = new System.Drawing.Size(654, 230);
            this.zedGraphControlGraph2.TabIndex = 17;
            // 
            // zedGraphControlGraph3
            // 
            this.zedGraphControlGraph3.Location = new System.Drawing.Point(6, 7);
            this.zedGraphControlGraph3.Name = "zedGraphControlGraph3";
            this.zedGraphControlGraph3.Size = new System.Drawing.Size(654, 230);
            this.zedGraphControlGraph3.TabIndex = 18;
            // 
            // timerGraph
            // 
            this.timerGraph.Interval = 1000;
            this.timerGraph.Tick += new System.EventHandler(this.timerGraph_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 685);
            this.Controls.Add(this.zedGraphControlGraph3);
            this.Controls.Add(this.zedGraphControlGraph2);
            this.Controls.Add(this.zedGraphControlGraph);
            this.Controls.Add(this.panelSets);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelValues);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomiarek 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelValues.ResumeLayout(false);
            this.panelValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelSets.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxCurrent;
        private System.Windows.Forms.TextBox textBoxVoltage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelValues;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panelSets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonOpenExcel;
        private System.Windows.Forms.Button buttonShow;
        private ZedGraph.ZedGraphControl zedGraphControlGraph;
        private ZedGraph.ZedGraphControl zedGraphControlGraph2;
        private ZedGraph.ZedGraphControl zedGraphControlGraph3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDiscon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxVolMid;
        private System.Windows.Forms.TextBox textBoxCurMid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPowMid;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label labelFreq;
        private System.Windows.Forms.Button buttonChangeFreq;
        private System.Windows.Forms.TextBox textBoxPower;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Timer timerGraph;
    }
}

