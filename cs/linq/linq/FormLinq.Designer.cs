namespace tomaszMatusiak
{
    partial class FormLinq
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
            this.DgvView = new System.Windows.Forms.DataGridView();
            this.bTest1 = new System.Windows.Forms.Button();
            this.bTest2 = new System.Windows.Forms.Button();
            this.bTest3 = new System.Windows.Forms.Button();
            this.bTest4 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvView
            // 
            this.DgvView.AllowUserToAddRows = false;
            this.DgvView.AllowUserToDeleteRows = false;
            this.DgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvView.Location = new System.Drawing.Point(12, 12);
            this.DgvView.Name = "DgvView";
            this.DgvView.ReadOnly = true;
            this.DgvView.Size = new System.Drawing.Size(720, 331);
            this.DgvView.TabIndex = 0;
            // 
            // bTest1
            // 
            this.bTest1.Location = new System.Drawing.Point(30, 352);
            this.bTest1.Name = "bTest1";
            this.bTest1.Size = new System.Drawing.Size(75, 23);
            this.bTest1.TabIndex = 1;
            this.bTest1.Text = "Test1";
            this.bTest1.UseVisualStyleBackColor = true;
            this.bTest1.Click += new System.EventHandler(this.bTest1_Click);
            // 
            // bTest2
            // 
            this.bTest2.Location = new System.Drawing.Point(111, 352);
            this.bTest2.Name = "bTest2";
            this.bTest2.Size = new System.Drawing.Size(75, 23);
            this.bTest2.TabIndex = 2;
            this.bTest2.Text = "Test 2";
            this.bTest2.UseVisualStyleBackColor = true;
            // 
            // bTest3
            // 
            this.bTest3.Location = new System.Drawing.Point(192, 352);
            this.bTest3.Name = "bTest3";
            this.bTest3.Size = new System.Drawing.Size(75, 23);
            this.bTest3.TabIndex = 3;
            this.bTest3.Text = "Test 3";
            this.bTest3.UseVisualStyleBackColor = true;
            // 
            // bTest4
            // 
            this.bTest4.Location = new System.Drawing.Point(274, 352);
            this.bTest4.Name = "bTest4";
            this.bTest4.Size = new System.Drawing.Size(75, 23);
            this.bTest4.TabIndex = 4;
            this.bTest4.Text = "Test 4";
            this.bTest4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(355, 352);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Test 5";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(437, 352);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Test 6";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FormLinq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 387);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bTest4);
            this.Controls.Add(this.bTest3);
            this.Controls.Add(this.bTest2);
            this.Controls.Add(this.bTest1);
            this.Controls.Add(this.DgvView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLinq";
            this.ShowIcon = false;
            this.Text = "Linq";
            ((System.ComponentModel.ISupportInitialize)(this.DgvView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvView;
        private System.Windows.Forms.Button bTest1;
        private System.Windows.Forms.Button bTest2;
        private System.Windows.Forms.Button bTest3;
        private System.Windows.Forms.Button bTest4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

