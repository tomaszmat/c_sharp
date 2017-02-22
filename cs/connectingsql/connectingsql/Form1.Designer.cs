namespace connectingsql
{
    partial class Form1
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxSqlStringToConnect = new System.Windows.Forms.TextBox();
            this.buttonAddPos = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(159, 27);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxSqlStringToConnect
            // 
            this.textBoxSqlStringToConnect.Location = new System.Drawing.Point(53, 29);
            this.textBoxSqlStringToConnect.Name = "textBoxSqlStringToConnect";
            this.textBoxSqlStringToConnect.Size = new System.Drawing.Size(100, 20);
            this.textBoxSqlStringToConnect.TabIndex = 1;
            // 
            // buttonAddPos
            // 
            this.buttonAddPos.Location = new System.Drawing.Point(240, 56);
            this.buttonAddPos.Name = "buttonAddPos";
            this.buttonAddPos.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPos.TabIndex = 2;
            this.buttonAddPos.Text = "Add";
            this.buttonAddPos.UseVisualStyleBackColor = true;
            this.buttonAddPos.Click += new System.EventHandler(this.buttonAddPos_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(240, 27);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Location = new System.Drawing.Point(29, 99);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.Size = new System.Drawing.Size(401, 150);
            this.dataGridViewInfo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 273);
            this.Controls.Add(this.dataGridViewInfo);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonAddPos);
            this.Controls.Add(this.textBoxSqlStringToConnect);
            this.Controls.Add(this.buttonConnect);
            this.Name = "Form1";
            this.Text = "xxxx";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxSqlStringToConnect;
        private System.Windows.Forms.Button buttonAddPos;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
    }
}

