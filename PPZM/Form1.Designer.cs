namespace PPZM
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxTgmax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExponenta = new System.Windows.Forms.TextBox();
            this.buttonExcelExport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxYoung = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelForce = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelYoung = new System.Windows.Forms.Label();
            this.textBoxLong = new System.Windows.Forms.TextBox();
            this.textBoxForce = new System.Windows.Forms.TextBox();
            this.labelLong = new System.Windows.Forms.Label();
            this.dataGridViewCalcData = new System.Windows.Forms.DataGridView();
            this.tanges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalcData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridViewCalcData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 463);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(338, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 104);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(596, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "tg a = f(l)";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "+tg a max";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "-tg a max";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(410, 439);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
           
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(256, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 9);
            this.label5.TabIndex = 18;
            this.label5.Text = "~~~~by tomasz m";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 96);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxTgmax);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxExponenta);
            this.panel2.Controls.Add(this.buttonExcelExport);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxYoung);
            this.panel2.Controls.Add(this.buttonCalc);
            this.panel2.Controls.Add(this.labelForce);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelYoung);
            this.panel2.Controls.Add(this.textBoxLong);
            this.panel2.Controls.Add(this.textBoxForce);
            this.panel2.Controls.Add(this.labelLong);
            this.panel2.Location = new System.Drawing.Point(258, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 207);
            this.panel2.TabIndex = 16;
            // 
            // textBoxTgmax
            // 
            this.textBoxTgmax.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTgmax.Location = new System.Drawing.Point(223, 96);
            this.textBoxTgmax.Name = "textBoxTgmax";
            this.textBoxTgmax.Size = new System.Drawing.Size(100, 26);
            this.textBoxTgmax.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(239, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "tg a max :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(250, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "[N * mm^2]";
            // 
            // textBoxExponenta
            // 
            this.textBoxExponenta.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExponenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxExponenta.Location = new System.Drawing.Point(214, 3);
            this.textBoxExponenta.Name = "textBoxExponenta";
            this.textBoxExponenta.Size = new System.Drawing.Size(29, 26);
            this.textBoxExponenta.TabIndex = 11;
            // 
            // buttonExcelExport
            // 
            this.buttonExcelExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcelExport.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcelExport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExcelExport.Location = new System.Drawing.Point(14, 167);
            this.buttonExcelExport.Name = "buttonExcelExport";
            this.buttonExcelExport.Size = new System.Drawing.Size(297, 35);
            this.buttonExcelExport.TabIndex = 9;
            this.buttonExcelExport.Text = "Otwórz wyniki w Excelu";
            this.buttonExcelExport.UseVisualStyleBackColor = true;
            this.buttonExcelExport.Click += new System.EventHandler(this.buttonExcelExport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(176, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "[N]";
            // 
            // textBoxYoung
            // 
            this.textBoxYoung.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYoung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxYoung.Location = new System.Drawing.Point(70, 6);
            this.textBoxYoung.Name = "textBoxYoung";
            this.textBoxYoung.Size = new System.Drawing.Size(100, 26);
            this.textBoxYoung.TabIndex = 1;
            // 
            // buttonCalc
            // 
            this.buttonCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCalc.Location = new System.Drawing.Point(14, 128);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(297, 35);
            this.buttonCalc.TabIndex = 4;
            this.buttonCalc.Text = "Oblicz";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelForce
            // 
            this.labelForce.AutoSize = true;
            this.labelForce.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForce.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForce.Location = new System.Drawing.Point(49, 67);
            this.labelForce.Name = "labelForce";
            this.labelForce.Size = new System.Drawing.Size(19, 18);
            this.labelForce.TabIndex = 7;
            this.labelForce.Text = "F:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(176, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "[mm]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(176, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "*10 ^";
            // 
            // labelYoung
            // 
            this.labelYoung.AutoSize = true;
            this.labelYoung.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYoung.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelYoung.Location = new System.Drawing.Point(27, 6);
            this.labelYoung.Name = "labelYoung";
            this.labelYoung.Size = new System.Drawing.Size(37, 18);
            this.labelYoung.TabIndex = 5;
            this.labelYoung.Text = "E x J:";
            // 
            // textBoxLong
            // 
            this.textBoxLong.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxLong.Location = new System.Drawing.Point(70, 35);
            this.textBoxLong.Name = "textBoxLong";
            this.textBoxLong.Size = new System.Drawing.Size(100, 26);
            this.textBoxLong.TabIndex = 2;
            // 
            // textBoxForce
            // 
            this.textBoxForce.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxForce.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxForce.Location = new System.Drawing.Point(70, 64);
            this.textBoxForce.Name = "textBoxForce";
            this.textBoxForce.Size = new System.Drawing.Size(100, 26);
            this.textBoxForce.TabIndex = 3;
            // 
            // labelLong
            // 
            this.labelLong.AutoSize = true;
            this.labelLong.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLong.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLong.Location = new System.Drawing.Point(48, 35);
            this.labelLong.Name = "labelLong";
            this.labelLong.Size = new System.Drawing.Size(16, 18);
            this.labelLong.TabIndex = 6;
            this.labelLong.Text = "l:";
            // 
            // dataGridViewCalcData
            // 
            this.dataGridViewCalcData.AllowUserToAddRows = false;
            this.dataGridViewCalcData.AllowUserToDeleteRows = false;
            this.dataGridViewCalcData.AllowUserToResizeColumns = false;
            this.dataGridViewCalcData.AllowUserToResizeRows = false;
            this.dataGridViewCalcData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewCalcData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalcData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tanges,
            this.b});
            this.dataGridViewCalcData.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewCalcData.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCalcData.Name = "dataGridViewCalcData";
            this.dataGridViewCalcData.ReadOnly = true;
            this.dataGridViewCalcData.Size = new System.Drawing.Size(240, 439);
            this.dataGridViewCalcData.TabIndex = 8;
            // 
            // tanges
            // 
            this.tanges.HeaderText = "α";
            this.tanges.Name = "tanges";
            this.tanges.ReadOnly = true;
            // 
            // b
            // 
            this.b.HeaderText = "b";
            this.b.Name = "b";
            this.b.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 463);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2a. Obliczenia dla zespołu prowadnicy linowej.";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalcData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelForce;
        private System.Windows.Forms.Label labelLong;
        private System.Windows.Forms.Label labelYoung;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox textBoxForce;
        private System.Windows.Forms.TextBox textBoxLong;
        private System.Windows.Forms.TextBox textBoxYoung;
        private System.Windows.Forms.DataGridView dataGridViewCalcData;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.Button buttonExcelExport;
        private System.Windows.Forms.TextBox textBoxExponenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxTgmax;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
    }
}

