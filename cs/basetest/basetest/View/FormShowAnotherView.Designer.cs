namespace TomaszMatusiakPracaDomowa.View
{
    partial class FormShowAnotherView
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
            this.dataGridViewAnotherShowForm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnotherShowForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAnotherShowForm
            // 
            this.dataGridViewAnotherShowForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnotherShowForm.Location = new System.Drawing.Point(29, 24);
            this.dataGridViewAnotherShowForm.Name = "dataGridViewAnotherShowForm";
            this.dataGridViewAnotherShowForm.Size = new System.Drawing.Size(533, 239);
            this.dataGridViewAnotherShowForm.TabIndex = 0;
            // 
            // FormShowAnotherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 341);
            this.Controls.Add(this.dataGridViewAnotherShowForm);
            this.Name = "FormShowAnotherView";
            this.Text = "Pokaz wiok ViewSecond";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnotherShowForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAnotherShowForm;
    }
}