namespace TomaszMatusiakPracaDomowa.View
{
    partial class FormShowLastView
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
            this.dataGridViewGraphShowLast = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGraphShowLast)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGraphShowLast
            // 
            this.dataGridViewGraphShowLast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGraphShowLast.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewGraphShowLast.Name = "dataGridViewGraphShowLast";
            this.dataGridViewGraphShowLast.Size = new System.Drawing.Size(610, 274);
            this.dataGridViewGraphShowLast.TabIndex = 0;
            // 
            // FormShowLastView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 291);
            this.Controls.Add(this.dataGridViewGraphShowLast);
            this.Name = "FormShowLastView";
            this.Text = "FormShowLastView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGraphShowLast)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGraphShowLast;
    }
}