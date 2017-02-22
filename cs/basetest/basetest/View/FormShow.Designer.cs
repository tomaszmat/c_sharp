namespace TomaszMatusiakPracaDomowa
{
    partial class formShow
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
            this.dataGridViewFormShow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFormShow
            // 
            this.dataGridViewFormShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFormShow.Location = new System.Drawing.Point(25, 24);
            this.dataGridViewFormShow.Name = "dataGridViewFormShow";
            this.dataGridViewFormShow.Size = new System.Drawing.Size(664, 300);
            this.dataGridViewFormShow.TabIndex = 0;
            // 
            // formShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 348);
            this.Controls.Add(this.dataGridViewFormShow);
            this.Name = "formShow";
            this.Text = "Pokaz widok ViewFirst";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFormShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFormShow;
    }
}