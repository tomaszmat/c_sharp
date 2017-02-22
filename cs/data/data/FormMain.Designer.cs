namespace TomaszMatusiakLab02_06052015
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
            this.buttonNew = new System.Windows.Forms.Button();
            this.labelRegisterNumber = new System.Windows.Forms.Label();
            this.labelSupply = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxRegisterNumber = new System.Windows.Forms.TextBox();
            this.textBoxSupply = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.dataGridViewArrivals = new System.Windows.Forms.DataGridView();
            this.ColumnRegisterNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSupply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.textBoxSearcher = new System.Windows.Forms.TextBox();
            this.radioButtonSortSuppluy = new System.Windows.Forms.RadioButton();
            this.radioButtonSortRegNum = new System.Windows.Forms.RadioButton();
            this.labelSort = new System.Windows.Forms.Label();
            this.buttonAutoReg = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonCleandGridView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrivals)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(40, 14);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 46);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "Nowy Przyjazd";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // labelRegisterNumber
            // 
            this.labelRegisterNumber.AutoSize = true;
            this.labelRegisterNumber.Location = new System.Drawing.Point(153, 14);
            this.labelRegisterNumber.Name = "labelRegisterNumber";
            this.labelRegisterNumber.Size = new System.Drawing.Size(104, 13);
            this.labelRegisterNumber.TabIndex = 1;
            this.labelRegisterNumber.Text = "Numer Rejestracyjny";
            // 
            // labelSupply
            // 
            this.labelSupply.AutoSize = true;
            this.labelSupply.Location = new System.Drawing.Point(259, 14);
            this.labelSupply.Name = "labelSupply";
            this.labelSupply.Size = new System.Drawing.Size(37, 13);
            this.labelSupply.TabIndex = 2;
            this.labelSupply.Text = "Towar";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(447, 14);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(29, 13);
            this.labelAmount.TabIndex = 3;
            this.labelAmount.Text = "Ilość";
            // 
            // textBoxRegisterNumber
            // 
            this.textBoxRegisterNumber.Location = new System.Drawing.Point(156, 40);
            this.textBoxRegisterNumber.Name = "textBoxRegisterNumber";
            this.textBoxRegisterNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegisterNumber.TabIndex = 4;
            this.textBoxRegisterNumber.Text = "PKL JY93";
            // 
            // textBoxSupply
            // 
            this.textBoxSupply.Location = new System.Drawing.Point(262, 40);
            this.textBoxSupply.Name = "textBoxSupply";
            this.textBoxSupply.Size = new System.Drawing.Size(182, 20);
            this.textBoxSupply.TabIndex = 5;
            this.textBoxSupply.Text = "Komputery";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(450, 40);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount.TabIndex = 6;
            this.textBoxAmount.Text = "1000";
            // 
            // dataGridViewArrivals
            // 
            this.dataGridViewArrivals.AllowUserToAddRows = false;
            this.dataGridViewArrivals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArrivals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArrivals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRegisterNumber,
            this.ColumnSupply,
            this.ColumnAmount});
            this.dataGridViewArrivals.Location = new System.Drawing.Point(40, 84);
            this.dataGridViewArrivals.Name = "dataGridViewArrivals";
            this.dataGridViewArrivals.Size = new System.Drawing.Size(510, 150);
            this.dataGridViewArrivals.TabIndex = 7;
            this.dataGridViewArrivals.TabStop = false;
            this.dataGridViewArrivals.UseWaitCursor = true;
            // 
            // ColumnRegisterNumber
            // 
            this.ColumnRegisterNumber.HeaderText = "Numer rejestracyjny";
            this.ColumnRegisterNumber.Name = "ColumnRegisterNumber";
            this.ColumnRegisterNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnSupply
            // 
            this.ColumnSupply.HeaderText = "Towar";
            this.ColumnSupply.Name = "ColumnSupply";
            this.ColumnSupply.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.HeaderText = "Ilość";
            this.ColumnAmount.Name = "ColumnAmount";
            this.ColumnAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(560, 84);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(117, 23);
            this.buttonSaveToFile.TabIndex = 8;
            this.buttonSaveToFile.Text = "Zapis do pliku";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(560, 113);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(117, 23);
            this.buttonReadFile.TabIndex = 9;
            this.buttonReadFile.Text = "Odczyt z pliku";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // textBoxSearcher
            // 
            this.textBoxSearcher.Location = new System.Drawing.Point(40, 318);
            this.textBoxSearcher.Name = "textBoxSearcher";
            this.textBoxSearcher.Size = new System.Drawing.Size(336, 20);
            this.textBoxSearcher.TabIndex = 10;
            this.textBoxSearcher.TextChanged += new System.EventHandler(this.textBoxSearcher_TextChanged);
            // 
            // radioButtonSortSuppluy
            // 
            this.radioButtonSortSuppluy.AutoSize = true;
            this.radioButtonSortSuppluy.Location = new System.Drawing.Point(156, 274);
            this.radioButtonSortSuppluy.Name = "radioButtonSortSuppluy";
            this.radioButtonSortSuppluy.Size = new System.Drawing.Size(66, 17);
            this.radioButtonSortSuppluy.TabIndex = 11;
            this.radioButtonSortSuppluy.TabStop = true;
            this.radioButtonSortSuppluy.Text = "Towarze";
            this.radioButtonSortSuppluy.UseVisualStyleBackColor = true;
            // 
            // radioButtonSortRegNum
            // 
            this.radioButtonSortRegNum.AutoSize = true;
            this.radioButtonSortRegNum.Location = new System.Drawing.Point(40, 274);
            this.radioButtonSortRegNum.Name = "radioButtonSortRegNum";
            this.radioButtonSortRegNum.Size = new System.Drawing.Size(84, 17);
            this.radioButtonSortRegNum.TabIndex = 12;
            this.radioButtonSortRegNum.TabStop = true;
            this.radioButtonSortRegNum.Text = "Numerze rej.";
            this.radioButtonSortRegNum.UseVisualStyleBackColor = true;
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new System.Drawing.Point(111, 248);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(71, 13);
            this.labelSort.TabIndex = 14;
            this.labelSort.Text = "Wyszukaj po:";
            // 
            // buttonAutoReg
            // 
            this.buttonAutoReg.Location = new System.Drawing.Point(497, 318);
            this.buttonAutoReg.Name = "buttonAutoReg";
            this.buttonAutoReg.Size = new System.Drawing.Size(162, 23);
            this.buttonAutoReg.TabIndex = 15;
            this.buttonAutoReg.Text = "Rejestrowanie automatyczne";
            this.buttonAutoReg.UseVisualStyleBackColor = true;
            this.buttonAutoReg.Click += new System.EventHandler(this.buttonAutoReg_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(497, 283);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(162, 23);
            this.buttonInfo.TabIndex = 16;
            this.buttonInfo.Text = "Info o Autorze";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonCleandGridView
            // 
            this.buttonCleandGridView.Location = new System.Drawing.Point(560, 143);
            this.buttonCleandGridView.Name = "buttonCleandGridView";
            this.buttonCleandGridView.Size = new System.Drawing.Size(117, 23);
            this.buttonCleandGridView.TabIndex = 17;
            this.buttonCleandGridView.Text = "Wyszczyść tabele";
            this.buttonCleandGridView.UseVisualStyleBackColor = true;
            this.buttonCleandGridView.Click += new System.EventHandler(this.buttonCleandGridView_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 399);
            this.Controls.Add(this.buttonCleandGridView);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonAutoReg);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.radioButtonSortRegNum);
            this.Controls.Add(this.radioButtonSortSuppluy);
            this.Controls.Add(this.textBoxSearcher);
            this.Controls.Add(this.buttonReadFile);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.dataGridViewArrivals);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxSupply);
            this.Controls.Add(this.textBoxRegisterNumber);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelSupply);
            this.Controls.Add(this.labelRegisterNumber);
            this.Controls.Add(this.buttonNew);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Rejestr przyjazdów";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrivals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Label labelRegisterNumber;
        private System.Windows.Forms.Label labelSupply;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxRegisterNumber;
        private System.Windows.Forms.TextBox textBoxSupply;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.DataGridView dataGridViewArrivals;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.TextBox textBoxSearcher;
        private System.Windows.Forms.RadioButton radioButtonSortSuppluy;
        private System.Windows.Forms.RadioButton radioButtonSortRegNum;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.Button buttonAutoReg;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRegisterNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSupply;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.Button buttonCleandGridView;
    }
}

