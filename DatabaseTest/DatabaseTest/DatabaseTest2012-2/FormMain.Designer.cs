namespace DatabaseTest
{
    partial class FormDataShow
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
            this.dataGridViewDataShow = new System.Windows.Forms.DataGridView();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonSampleInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDataShow
            // 
            this.dataGridViewDataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataShow.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewDataShow.Name = "dataGridViewDataShow";
            this.dataGridViewDataShow.Size = new System.Drawing.Size(521, 268);
            this.dataGridViewDataShow.TabIndex = 0;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(541, 13);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(157, 38);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Wyświetl";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonSampleInsert
            // 
            this.buttonSampleInsert.Location = new System.Drawing.Point(541, 57);
            this.buttonSampleInsert.Name = "buttonSampleInsert";
            this.buttonSampleInsert.Size = new System.Drawing.Size(157, 38);
            this.buttonSampleInsert.TabIndex = 6;
            this.buttonSampleInsert.Text = "Wstaw przykładowe";
            this.buttonSampleInsert.UseVisualStyleBackColor = true;
            this.buttonSampleInsert.Click += new System.EventHandler(this.buttonSampleInsert_Click);
            // 
            // FormDataShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 317);
            this.Controls.Add(this.buttonSampleInsert);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.dataGridViewDataShow);
            this.Name = "FormDataShow";
            this.Text = "Program testujący połączenie z bazą danych";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDataShow;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonSampleInsert;
    }
}

