namespace TomaszMatusiakLab02_06052015
{
    partial class FormInfo
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
            this.labelSurnName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNumberTelephone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSurnName
            // 
            this.labelSurnName.AutoSize = true;
            this.labelSurnName.Location = new System.Drawing.Point(134, 112);
            this.labelSurnName.Name = "labelSurnName";
            this.labelSurnName.Size = new System.Drawing.Size(90, 13);
            this.labelSurnName.TabIndex = 0;
            this.labelSurnName.Text = "Tomasz Matusiak";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(94, 146);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(173, 13);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "matusiaktomasz@windowslive.com";
            // 
            // labelNumberTelephone
            // 
            this.labelNumberTelephone.AutoSize = true;
            this.labelNumberTelephone.Location = new System.Drawing.Point(117, 179);
            this.labelNumberTelephone.Name = "labelNumberTelephone";
            this.labelNumberTelephone.Size = new System.Drawing.Size(120, 13);
            this.labelNumberTelephone.TabIndex = 2;
            this.labelNumberTelephone.Text = "Nr. Tel.  881 - 211 - 636";
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 315);
            this.Controls.Add(this.labelNumberTelephone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelSurnName);
            this.Name = "FormInfo";
            this.Text = "Informacje o autorze";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormInfo_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSurnName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNumberTelephone;
    }
}