namespace TomaszMatusiakLab02_06052015
{
    partial class FormAutoReg
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
            this.timerAutoReg = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewAutoRegArrivals = new System.Windows.Forms.DataGridView();
            this.RegisterNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutoRegArrivals)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAutoReg
            // 
            this.timerAutoReg.Enabled = true;
            this.timerAutoReg.Tick += new System.EventHandler(this.timerAutoReg_Tick);
            // 
            // dataGridViewAutoRegArrivals
            // 
            this.dataGridViewAutoRegArrivals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAutoRegArrivals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegisterNumber,
            this.Supply,
            this.Amount});
            this.dataGridViewAutoRegArrivals.Location = new System.Drawing.Point(38, 53);
            this.dataGridViewAutoRegArrivals.Name = "dataGridViewAutoRegArrivals";
            this.dataGridViewAutoRegArrivals.Size = new System.Drawing.Size(471, 150);
            this.dataGridViewAutoRegArrivals.TabIndex = 0;
            
            // 
            // RegisterNumber
            // 
            this.RegisterNumber.HeaderText = "Rejestracja";
            this.RegisterNumber.Name = "RegisterNumber";
            // 
            // Supply
            // 
            this.Supply.HeaderText = "Towar";
            this.Supply.Name = "Supply";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Ilość";
            this.Amount.Name = "Amount";
            // 
            // FormAutoReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 285);
            this.Controls.Add(this.dataGridViewAutoRegArrivals);
            this.Name = "FormAutoReg";
            this.Text = "FormAutoReg";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutoRegArrivals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerAutoReg;
        private System.Windows.Forms.DataGridView dataGridViewAutoRegArrivals;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisterNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supply;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}