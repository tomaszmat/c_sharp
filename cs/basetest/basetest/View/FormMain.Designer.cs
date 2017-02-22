namespace TomaszMatusiakPracaDomowa
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
            this.dataGridViewDataShow = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.radioButtonDepartment = new System.Windows.Forms.RadioButton();
            this.radioButtonViewOrderData = new System.Windows.Forms.RadioButton();
            this.radioButtonID = new System.Windows.Forms.RadioButton();
            this.radioButtonWhoOrdering = new System.Windows.Forms.RadioButton();
            this.textBoxWhatDelete = new System.Windows.Forms.TextBox();
            this.labelSingleDelete = new System.Windows.Forms.Label();
            this.textBoxPosition1 = new System.Windows.Forms.TextBox();
            this.textBoxPoistion2 = new System.Windows.Forms.TextBox();
            this.textBoxPosition3 = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPosition4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonView1 = new System.Windows.Forms.Button();
            this.buttonView2 = new System.Windows.Forms.Button();
            this.buttonView3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDataShow
            // 
            this.dataGridViewDataShow.AllowUserToAddRows = false;
            this.dataGridViewDataShow.AllowUserToDeleteRows = false;
            this.dataGridViewDataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataShow.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDataShow.Name = "dataGridViewDataShow";
            this.dataGridViewDataShow.Size = new System.Drawing.Size(848, 146);
            this.dataGridViewDataShow.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(122, 312);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(553, 187);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(12, 210);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 3;
            this.buttonRead.Text = "Wczytaj";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // radioButtonDepartment
            // 
            this.radioButtonDepartment.AutoSize = true;
            this.radioButtonDepartment.Location = new System.Drawing.Point(12, 164);
            this.radioButtonDepartment.Name = "radioButtonDepartment";
            this.radioButtonDepartment.Size = new System.Drawing.Size(90, 17);
            this.radioButtonDepartment.TabIndex = 4;
            this.radioButtonDepartment.TabStop = true;
            this.radioButtonDepartment.Text = "\"Department\"";
            this.radioButtonDepartment.UseVisualStyleBackColor = true;
            // 
            // radioButtonViewOrderData
            // 
            this.radioButtonViewOrderData.AutoSize = true;
            this.radioButtonViewOrderData.Location = new System.Drawing.Point(122, 164);
            this.radioButtonViewOrderData.Name = "radioButtonViewOrderData";
            this.radioButtonViewOrderData.Size = new System.Drawing.Size(74, 17);
            this.radioButtonViewOrderData.TabIndex = 5;
            this.radioButtonViewOrderData.TabStop = true;
            this.radioButtonViewOrderData.Text = "OrderData";
            this.radioButtonViewOrderData.UseVisualStyleBackColor = true;
            // 
            // radioButtonID
            // 
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Location = new System.Drawing.Point(12, 187);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(55, 17);
            this.radioButtonID.TabIndex = 6;
            this.radioButtonID.TabStop = true;
            this.radioButtonID.Text = "Osoby";
            this.radioButtonID.UseVisualStyleBackColor = true;
            // 
            // radioButtonWhoOrdering
            // 
            this.radioButtonWhoOrdering.AutoSize = true;
            this.radioButtonWhoOrdering.Location = new System.Drawing.Point(122, 187);
            this.radioButtonWhoOrdering.Name = "radioButtonWhoOrdering";
            this.radioButtonWhoOrdering.Size = new System.Drawing.Size(88, 17);
            this.radioButtonWhoOrdering.TabIndex = 7;
            this.radioButtonWhoOrdering.TabStop = true;
            this.radioButtonWhoOrdering.Text = "WhoOrdering";
            this.radioButtonWhoOrdering.UseVisualStyleBackColor = true;
            // 
            // textBoxWhatDelete
            // 
            this.textBoxWhatDelete.Location = new System.Drawing.Point(447, 187);
            this.textBoxWhatDelete.Name = "textBoxWhatDelete";
            this.textBoxWhatDelete.Size = new System.Drawing.Size(100, 20);
            this.textBoxWhatDelete.TabIndex = 8;
            // 
            // labelSingleDelete
            // 
            this.labelSingleDelete.AutoSize = true;
            this.labelSingleDelete.Location = new System.Drawing.Point(454, 168);
            this.labelSingleDelete.Name = "labelSingleDelete";
            this.labelSingleDelete.Size = new System.Drawing.Size(154, 13);
            this.labelSingleDelete.TabIndex = 9;
            this.labelSingleDelete.Text = "Usuñ pojedynczá pozycje o ID:";
            // 
            // textBoxPosition1
            // 
            this.textBoxPosition1.Location = new System.Drawing.Point(16, 281);
            this.textBoxPosition1.Name = "textBoxPosition1";
            this.textBoxPosition1.Size = new System.Drawing.Size(100, 20);
            this.textBoxPosition1.TabIndex = 11;
            // 
            // textBoxPoistion2
            // 
            this.textBoxPoistion2.Location = new System.Drawing.Point(122, 281);
            this.textBoxPoistion2.Name = "textBoxPoistion2";
            this.textBoxPoistion2.Size = new System.Drawing.Size(100, 20);
            this.textBoxPoistion2.TabIndex = 12;
            // 
            // textBoxPosition3
            // 
            this.textBoxPosition3.Location = new System.Drawing.Point(228, 281);
            this.textBoxPosition3.Name = "textBoxPosition3";
            this.textBoxPosition3.Size = new System.Drawing.Size(100, 20);
            this.textBoxPosition3.TabIndex = 13;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(13, 258);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(369, 13);
            this.labelInfo.TabIndex = 14;
            this.labelInfo.Text = "Wpisuj w odpowiedniej kolejnosci w pola informacje a nastepnie kliknij dodaj.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "(Nie uwzglédniaj pola ID)";
            // 
            // textBoxPosition4
            // 
            this.textBoxPosition4.Location = new System.Drawing.Point(334, 281);
            this.textBoxPosition4.Name = "textBoxPosition4";
            this.textBoxPosition4.Size = new System.Drawing.Size(100, 20);
            this.textBoxPosition4.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Zbédne pozostaw puste.";
            // 
            // buttonView1
            // 
            this.buttonView1.Location = new System.Drawing.Point(505, 248);
            this.buttonView1.Name = "buttonView1";
            this.buttonView1.Size = new System.Drawing.Size(75, 23);
            this.buttonView1.TabIndex = 18;
            this.buttonView1.Text = "View1";
            this.buttonView1.UseVisualStyleBackColor = true;
            this.buttonView1.Click += new System.EventHandler(this.buttonView1_Click_1);
            // 
            // buttonView2
            // 
            this.buttonView2.Location = new System.Drawing.Point(505, 277);
            this.buttonView2.Name = "buttonView2";
            this.buttonView2.Size = new System.Drawing.Size(75, 23);
            this.buttonView2.TabIndex = 19;
            this.buttonView2.Text = "View 2";
            this.buttonView2.UseVisualStyleBackColor = true;
            this.buttonView2.Click += new System.EventHandler(this.buttonView2_Click);
            // 
            // buttonView3
            // 
            this.buttonView3.Location = new System.Drawing.Point(505, 306);
            this.buttonView3.Name = "buttonView3";
            this.buttonView3.Size = new System.Drawing.Size(75, 23);
            this.buttonView3.TabIndex = 20;
            this.buttonView3.Text = "View 3";
            this.buttonView3.UseVisualStyleBackColor = true;
            this.buttonView3.Click += new System.EventHandler(this.buttonView3_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 347);
            this.Controls.Add(this.buttonView3);
            this.Controls.Add(this.buttonView2);
            this.Controls.Add(this.buttonView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPosition4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxPosition3);
            this.Controls.Add(this.textBoxPoistion2);
            this.Controls.Add(this.textBoxPosition1);
            this.Controls.Add(this.labelSingleDelete);
            this.Controls.Add(this.textBoxWhatDelete);
            this.Controls.Add(this.radioButtonWhoOrdering);
            this.Controls.Add(this.radioButtonID);
            this.Controls.Add(this.radioButtonViewOrderData);
            this.Controls.Add(this.radioButtonDepartment);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewDataShow);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Zarzádzanie bazá danych";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDataShow;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.RadioButton radioButtonDepartment;
        private System.Windows.Forms.RadioButton radioButtonViewOrderData;
        private System.Windows.Forms.RadioButton radioButtonID;
        private System.Windows.Forms.RadioButton radioButtonWhoOrdering;
        private System.Windows.Forms.TextBox textBoxWhatDelete;
        private System.Windows.Forms.Label labelSingleDelete;
        private System.Windows.Forms.TextBox textBoxPosition1;
        private System.Windows.Forms.TextBox textBoxPoistion2;
        private System.Windows.Forms.TextBox textBoxPosition3;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPosition4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonView1;
        private System.Windows.Forms.Button buttonView2;
        private System.Windows.Forms.Button buttonView3;
    }
}