namespace ThreadsTimer
{
    partial class FormInterest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInterest));
            this.listBoxInterest = new System.Windows.Forms.ListBox();
            this.radioButtonAction = new System.Windows.Forms.RadioButton();
            this.radioButtonBalancedMarket = new System.Windows.Forms.RadioButton();
            this.radioButtonMoneyMarket = new System.Windows.Forms.RadioButton();
            this.radioButtonDebentures = new System.Windows.Forms.RadioButton();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            this.textBoxHow = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.timerInterest = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewInterest = new System.Windows.Forms.DataGridView();
            this.ColumnInterestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInterestValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelChanges = new System.Windows.Forms.Label();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszStanPorfelaDoXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszDoPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjdźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.użytkownikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyświetlStanPortfelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmienLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńHasłoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBarInterest = new System.Windows.Forms.ProgressBar();
            this.buttonShowUserListToThieft = new System.Windows.Forms.Button();
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.panelUser = new System.Windows.Forms.Panel();
            this.labelThieftCounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInterest)).BeginInit();
            this.panelPicture.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxInterest
            // 
            this.listBoxInterest.FormattingEnabled = true;
            this.listBoxInterest.Location = new System.Drawing.Point(243, 332);
            this.listBoxInterest.Name = "listBoxInterest";
            this.listBoxInterest.Size = new System.Drawing.Size(523, 147);
            this.listBoxInterest.TabIndex = 0;
            // 
            // radioButtonAction
            // 
            this.radioButtonAction.AutoSize = true;
            this.radioButtonAction.Location = new System.Drawing.Point(122, 35);
            this.radioButtonAction.Name = "radioButtonAction";
            this.radioButtonAction.Size = new System.Drawing.Size(52, 17);
            this.radioButtonAction.TabIndex = 1;
            this.radioButtonAction.TabStop = true;
            this.radioButtonAction.Text = "Akcje";
            this.radioButtonAction.UseVisualStyleBackColor = true;
            // 
            // radioButtonBalancedMarket
            // 
            this.radioButtonBalancedMarket.AutoSize = true;
            this.radioButtonBalancedMarket.Location = new System.Drawing.Point(5, 35);
            this.radioButtonBalancedMarket.Name = "radioButtonBalancedMarket";
            this.radioButtonBalancedMarket.Size = new System.Drawing.Size(111, 17);
            this.radioButtonBalancedMarket.TabIndex = 2;
            this.radioButtonBalancedMarket.TabStop = true;
            this.radioButtonBalancedMarket.Text = "R. Zrównoważony";
            this.radioButtonBalancedMarket.UseVisualStyleBackColor = true;
            // 
            // radioButtonMoneyMarket
            // 
            this.radioButtonMoneyMarket.AutoSize = true;
            this.radioButtonMoneyMarket.Location = new System.Drawing.Point(5, 58);
            this.radioButtonMoneyMarket.Name = "radioButtonMoneyMarket";
            this.radioButtonMoneyMarket.Size = new System.Drawing.Size(97, 17);
            this.radioButtonMoneyMarket.TabIndex = 3;
            this.radioButtonMoneyMarket.TabStop = true;
            this.radioButtonMoneyMarket.Text = "R. Pieniężnego";
            this.radioButtonMoneyMarket.UseVisualStyleBackColor = true;
            // 
            // radioButtonDebentures
            // 
            this.radioButtonDebentures.AutoSize = true;
            this.radioButtonDebentures.Location = new System.Drawing.Point(122, 58);
            this.radioButtonDebentures.Name = "radioButtonDebentures";
            this.radioButtonDebentures.Size = new System.Drawing.Size(69, 17);
            this.radioButtonDebentures.TabIndex = 4;
            this.radioButtonDebentures.TabStop = true;
            this.radioButtonDebentures.Text = "Obligacje";
            this.radioButtonDebentures.UseVisualStyleBackColor = true;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(93, 107);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(98, 23);
            this.buttonBuy.TabIndex = 5;
            this.buttonBuy.Text = "Kup";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(3, 107);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(90, 23);
            this.buttonSell.TabIndex = 6;
            this.buttonSell.Text = "Sprzedaj";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // textBoxHow
            // 
            this.textBoxHow.Location = new System.Drawing.Point(5, 81);
            this.textBoxHow.Name = "textBoxHow";
            this.textBoxHow.Size = new System.Drawing.Size(186, 20);
            this.textBoxHow.TabIndex = 8;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(3, 19);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(65, 13);
            this.labelUser.TabIndex = 11;
            this.labelUser.Text = "Użytkownik:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(74, 19);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 12;
            this.labelUsername.Text = "Username";
            // 
            // timerInterest
            // 
            this.timerInterest.Interval = 10000;
            this.timerInterest.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridViewInterest
            // 
            this.dataGridViewInterest.AllowUserToAddRows = false;
            this.dataGridViewInterest.AllowUserToDeleteRows = false;
            this.dataGridViewInterest.AllowUserToResizeColumns = false;
            this.dataGridViewInterest.AllowUserToResizeRows = false;
            this.dataGridViewInterest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInterest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInterest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnInterestName,
            this.ColumnInterestValue,
            this.ColumnChange,
            this.ColumnTime});
            this.dataGridViewInterest.Location = new System.Drawing.Point(2, 170);
            this.dataGridViewInterest.Name = "dataGridViewInterest";
            this.dataGridViewInterest.Size = new System.Drawing.Size(774, 114);
            this.dataGridViewInterest.TabIndex = 14;
            // 
            // ColumnInterestName
            // 
            this.ColumnInterestName.HeaderText = "Rodzaj notowań";
            this.ColumnInterestName.Name = "ColumnInterestName";
            // 
            // ColumnInterestValue
            // 
            this.ColumnInterestValue.HeaderText = "Wartość";
            this.ColumnInterestValue.Name = "ColumnInterestValue";
            // 
            // ColumnChange
            // 
            this.ColumnChange.HeaderText = "Zamiana o:";
            this.ColumnChange.Name = "ColumnChange";
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Czas";
            this.ColumnTime.Name = "ColumnTime";
            // 
            // labelChanges
            // 
            this.labelChanges.AutoSize = true;
            this.labelChanges.Location = new System.Drawing.Point(455, 316);
            this.labelChanges.Name = "labelChanges";
            this.labelChanges.Size = new System.Drawing.Size(104, 13);
            this.labelChanges.TabIndex = 15;
            this.labelChanges.Text = "Zmiany na rachunku";
            // 
            // panelPicture
            // 
            this.panelPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPicture.BackgroundImage")));
            this.panelPicture.Controls.Add(this.menuStrip1);
            this.panelPicture.Location = new System.Drawing.Point(2, 1);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(774, 163);
            this.panelPicture.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.pomocToolStripMenuItem,
            this.użytkownikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszStanPorfelaDoXMLToolStripMenuItem,
            this.zapiszDoPDFToolStripMenuItem,
            this.wylogujToolStripMenuItem,
            this.wyjdźToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszStanPorfelaDoXMLToolStripMenuItem
            // 
            this.zapiszStanPorfelaDoXMLToolStripMenuItem.Name = "zapiszStanPorfelaDoXMLToolStripMenuItem";
            this.zapiszStanPorfelaDoXMLToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.zapiszStanPorfelaDoXMLToolStripMenuItem.Text = "Zapisz stan porfela do XML ";
            this.zapiszStanPorfelaDoXMLToolStripMenuItem.Click += new System.EventHandler(this.zapiszStanPorfelaDoXMLToolStripMenuItem_Click);
            // 
            // zapiszDoPDFToolStripMenuItem
            // 
            this.zapiszDoPDFToolStripMenuItem.Name = "zapiszDoPDFToolStripMenuItem";
            this.zapiszDoPDFToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.zapiszDoPDFToolStripMenuItem.Text = "Zapisz notowania do PDF";
            this.zapiszDoPDFToolStripMenuItem.Click += new System.EventHandler(this.zapiszDoPDFToolStripMenuItem_Click);
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // wyjdźToolStripMenuItem
            // 
            this.wyjdźToolStripMenuItem.Name = "wyjdźToolStripMenuItem";
            this.wyjdźToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.wyjdźToolStripMenuItem.Text = "Wyjdź";
            this.wyjdźToolStripMenuItem.Click += new System.EventHandler(this.wyjdźToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // użytkownikToolStripMenuItem
            // 
            this.użytkownikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyświetlStanPortfelaToolStripMenuItem,
            this.zmienLoginToolStripMenuItem,
            this.zmieńHasłoToolStripMenuItem});
            this.użytkownikToolStripMenuItem.Name = "użytkownikToolStripMenuItem";
            this.użytkownikToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.użytkownikToolStripMenuItem.Text = "Użytkownik";
            // 
            // wyświetlStanPortfelaToolStripMenuItem
            // 
            this.wyświetlStanPortfelaToolStripMenuItem.Name = "wyświetlStanPortfelaToolStripMenuItem";
            this.wyświetlStanPortfelaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.wyświetlStanPortfelaToolStripMenuItem.Text = "Wyświetl stan portfela";
            this.wyświetlStanPortfelaToolStripMenuItem.Click += new System.EventHandler(this.wyświetlStanPortfelaToolStripMenuItem_Click);
            // 
            // zmienLoginToolStripMenuItem
            // 
            this.zmienLoginToolStripMenuItem.Name = "zmienLoginToolStripMenuItem";
            this.zmienLoginToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.zmienLoginToolStripMenuItem.Text = "Zmień login";
            // 
            // zmieńHasłoToolStripMenuItem
            // 
            this.zmieńHasłoToolStripMenuItem.Name = "zmieńHasłoToolStripMenuItem";
            this.zmieńHasłoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.zmieńHasłoToolStripMenuItem.Text = "Zmień hasło";
            // 
            // progressBarInterest
            // 
            this.progressBarInterest.BackColor = System.Drawing.SystemColors.ControlLight;
            this.progressBarInterest.Location = new System.Drawing.Point(2, 290);
            this.progressBarInterest.Name = "progressBarInterest";
            this.progressBarInterest.Size = new System.Drawing.Size(774, 23);
            this.progressBarInterest.TabIndex = 20;
            // 
            // buttonShowUserListToThieft
            // 
            this.buttonShowUserListToThieft.Enabled = false;
            this.buttonShowUserListToThieft.Location = new System.Drawing.Point(12, 521);
            this.buttonShowUserListToThieft.Name = "buttonShowUserListToThieft";
            this.buttonShowUserListToThieft.Size = new System.Drawing.Size(200, 23);
            this.buttonShowUserListToThieft.TabIndex = 19;
            this.buttonShowUserListToThieft.Text = "Okradnij innych inwestorów";
            this.buttonShowUserListToThieft.UseVisualStyleBackColor = true;
            this.buttonShowUserListToThieft.Click += new System.EventHandler(this.buttonUserListView_Click);
            // 
            // timerProgress
            // 
            this.timerProgress.Interval = 1000;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelUser.Controls.Add(this.radioButtonBalancedMarket);
            this.panelUser.Controls.Add(this.radioButtonMoneyMarket);
            this.panelUser.Controls.Add(this.radioButtonAction);
            this.panelUser.Controls.Add(this.radioButtonDebentures);
            this.panelUser.Controls.Add(this.buttonBuy);
            this.panelUser.Controls.Add(this.buttonSell);
            this.panelUser.Controls.Add(this.textBoxHow);
            this.panelUser.Controls.Add(this.labelUsername);
            this.panelUser.Controls.Add(this.labelUser);
            this.panelUser.Location = new System.Drawing.Point(12, 332);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(200, 147);
            this.panelUser.TabIndex = 25;
            // 
            // labelThieftCounter
            // 
            this.labelThieftCounter.AutoSize = true;
            this.labelThieftCounter.Location = new System.Drawing.Point(110, 498);
            this.labelThieftCounter.Name = "labelThieftCounter";
            this.labelThieftCounter.Size = new System.Drawing.Size(93, 13);
            this.labelThieftCounter.TabIndex = 26;
            this.labelThieftCounter.Text = "labelThieftCounter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Liczba gwiazdek:";
            // 
            // FormInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelThieftCounter);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.progressBarInterest);
            this.Controls.Add(this.panelPicture);
            this.Controls.Add(this.buttonShowUserListToThieft);
            this.Controls.Add(this.labelChanges);
            this.Controls.Add(this.dataGridViewInterest);
            this.Controls.Add(this.listBoxInterest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInterest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symulator inwestycyjny by Tomasz Matusiak ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInterest)).EndInit();
            this.panelPicture.ResumeLayout(false);
            this.panelPicture.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxInterest;
        private System.Windows.Forms.RadioButton radioButtonAction;
        private System.Windows.Forms.RadioButton radioButtonBalancedMarket;
        private System.Windows.Forms.RadioButton radioButtonMoneyMarket;
        private System.Windows.Forms.RadioButton radioButtonDebentures;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.TextBox textBoxHow;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Timer timerInterest;
        private System.Windows.Forms.DataGridView dataGridViewInterest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInterestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInterestValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.Label labelChanges;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.Button buttonShowUserListToThieft;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBarInterest;
        private System.Windows.Forms.Timer timerProgress;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszStanPorfelaDoXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszDoPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjdźToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem użytkownikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyświetlStanPortfelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmienLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńHasłoToolStripMenuItem;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label labelThieftCounter;
        private System.Windows.Forms.Label label1;
        
    }
}