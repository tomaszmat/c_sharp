namespace FormHello.cs.View
{
    partial class FormUserList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserList));
            this.dataGridViewUserList = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDoThieft = new System.Windows.Forms.Button();
            this.textBoxUserToThieft = new System.Windows.Forms.TextBox();
            this.labelUsernameToThief = new System.Windows.Forms.Label();
            this.radioButtonDebentures = new System.Windows.Forms.RadioButton();
            this.radioButtonMoneyMarket = new System.Windows.Forms.RadioButton();
            this.radioButtonBalancedMarket = new System.Windows.Forms.RadioButton();
            this.radioButtonAction = new System.Windows.Forms.RadioButton();
            this.labelInfoWhich = new System.Windows.Forms.Label();
            this.panelThieftPic = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUserList
            // 
            this.dataGridViewUserList.AllowUserToAddRows = false;
            this.dataGridViewUserList.AllowUserToDeleteRows = false;
            this.dataGridViewUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserList.Location = new System.Drawing.Point(13, 10);
            this.dataGridViewUserList.Name = "dataGridViewUserList";
            this.dataGridViewUserList.Size = new System.Drawing.Size(545, 149);
            this.dataGridViewUserList.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(434, 328);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(124, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Zamknij okno";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDoThieft
            // 
            this.buttonDoThieft.Location = new System.Drawing.Point(21, 126);
            this.buttonDoThieft.Name = "buttonDoThieft";
            this.buttonDoThieft.Size = new System.Drawing.Size(225, 44);
            this.buttonDoThieft.TabIndex = 21;
            this.buttonDoThieft.Text = "Dokonaj kradzieży :)";
            this.buttonDoThieft.UseVisualStyleBackColor = true;
            this.buttonDoThieft.Click += new System.EventHandler(this.buttonDoThieft_Click);
            // 
            // textBoxUserToThieft
            // 
            this.textBoxUserToThieft.Location = new System.Drawing.Point(21, 31);
            this.textBoxUserToThieft.Name = "textBoxUserToThieft";
            this.textBoxUserToThieft.Size = new System.Drawing.Size(222, 20);
            this.textBoxUserToThieft.TabIndex = 23;
            // 
            // labelUsernameToThief
            // 
            this.labelUsernameToThief.AutoSize = true;
            this.labelUsernameToThief.Location = new System.Drawing.Point(21, 15);
            this.labelUsernameToThief.Name = "labelUsernameToThief";
            this.labelUsernameToThief.Size = new System.Drawing.Size(225, 13);
            this.labelUsernameToThief.TabIndex = 24;
            this.labelUsernameToThief.Text = "Wpisz nazwe gracza, którego chcesz okraść: ";
            // 
            // radioButtonDebentures
            // 
            this.radioButtonDebentures.AutoSize = true;
            this.radioButtonDebentures.Location = new System.Drawing.Point(149, 70);
            this.radioButtonDebentures.Name = "radioButtonDebentures";
            this.radioButtonDebentures.Size = new System.Drawing.Size(69, 17);
            this.radioButtonDebentures.TabIndex = 29;
            this.radioButtonDebentures.TabStop = true;
            this.radioButtonDebentures.Text = "Obligacje";
            this.radioButtonDebentures.UseVisualStyleBackColor = true;
            // 
            // radioButtonMoneyMarket
            // 
            this.radioButtonMoneyMarket.AutoSize = true;
            this.radioButtonMoneyMarket.Location = new System.Drawing.Point(21, 93);
            this.radioButtonMoneyMarket.Name = "radioButtonMoneyMarket";
            this.radioButtonMoneyMarket.Size = new System.Drawing.Size(97, 17);
            this.radioButtonMoneyMarket.TabIndex = 28;
            this.radioButtonMoneyMarket.TabStop = true;
            this.radioButtonMoneyMarket.Text = "R. Pieniężnego";
            this.radioButtonMoneyMarket.UseVisualStyleBackColor = true;
            // 
            // radioButtonBalancedMarket
            // 
            this.radioButtonBalancedMarket.AutoSize = true;
            this.radioButtonBalancedMarket.Location = new System.Drawing.Point(21, 70);
            this.radioButtonBalancedMarket.Name = "radioButtonBalancedMarket";
            this.radioButtonBalancedMarket.Size = new System.Drawing.Size(111, 17);
            this.radioButtonBalancedMarket.TabIndex = 27;
            this.radioButtonBalancedMarket.TabStop = true;
            this.radioButtonBalancedMarket.Text = "R. Zrównoważony";
            this.radioButtonBalancedMarket.UseVisualStyleBackColor = true;
            // 
            // radioButtonAction
            // 
            this.radioButtonAction.AutoSize = true;
            this.radioButtonAction.Location = new System.Drawing.Point(149, 93);
            this.radioButtonAction.Name = "radioButtonAction";
            this.radioButtonAction.Size = new System.Drawing.Size(52, 17);
            this.radioButtonAction.TabIndex = 26;
            this.radioButtonAction.TabStop = true;
            this.radioButtonAction.Text = "Akcje";
            this.radioButtonAction.UseVisualStyleBackColor = true;
            // 
            // labelInfoWhich
            // 
            this.labelInfoWhich.AutoSize = true;
            this.labelInfoWhich.Location = new System.Drawing.Point(18, 54);
            this.labelInfoWhich.Name = "labelInfoWhich";
            this.labelInfoWhich.Size = new System.Drawing.Size(125, 13);
            this.labelInfoWhich.TabIndex = 31;
            this.labelInfoWhich.Text = "Wybierz rodzaj podmiotu:";
            // 
            // panelThieftPic
            // 
            this.panelThieftPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelThieftPic.BackgroundImage")));
            this.panelThieftPic.Location = new System.Drawing.Point(410, 165);
            this.panelThieftPic.Name = "panelThieftPic";
            this.panelThieftPic.Size = new System.Drawing.Size(147, 157);
            this.panelThieftPic.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelUsernameToThief);
            this.panel1.Controls.Add(this.textBoxUserToThieft);
            this.panel1.Controls.Add(this.buttonDoThieft);
            this.panel1.Controls.Add(this.radioButtonMoneyMarket);
            this.panel1.Controls.Add(this.radioButtonDebentures);
            this.panel1.Controls.Add(this.labelInfoWhich);
            this.panel1.Controls.Add(this.radioButtonBalancedMarket);
            this.panel1.Controls.Add(this.radioButtonAction);
            this.panel1.Location = new System.Drawing.Point(13, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 186);
            this.panel1.TabIndex = 33;
            // 
            // FormUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 359);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelThieftPic);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewUserList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUserList";
            this.Text = "Lista użytkowników";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUserList;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDoThieft;
        private System.Windows.Forms.TextBox textBoxUserToThieft;
        private System.Windows.Forms.Label labelUsernameToThief;
        private System.Windows.Forms.RadioButton radioButtonDebentures;
        private System.Windows.Forms.RadioButton radioButtonMoneyMarket;
        private System.Windows.Forms.RadioButton radioButtonBalancedMarket;
        private System.Windows.Forms.RadioButton radioButtonAction;
        private System.Windows.Forms.Label labelInfoWhich;
        private System.Windows.Forms.Panel panelThieftPic;
        private System.Windows.Forms.Panel panel1;
    }
}