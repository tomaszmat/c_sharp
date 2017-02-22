namespace XmlExample
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
            this.TerminKolokwium = new System.Windows.Forms.DateTimePicker();
            this.ZaliczenieZaObecnosc = new System.Windows.Forms.CheckBox();
            this.WlasneMaterialy = new System.Windows.Forms.CheckBox();
            this.PoziomLatwe = new System.Windows.Forms.RadioButton();
            this.PoziomTrudnosci = new System.Windows.Forms.GroupBox();
            this.PoziomTrudne = new System.Windows.Forms.RadioButton();
            this.PoziomSrednie = new System.Windows.Forms.RadioButton();
            this.Bonusy = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PytanieWyciagajace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CzasPisania = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Wyczysc = new System.Windows.Forms.Button();
            this.Wczytaj = new System.Windows.Forms.Button();
            this.Zapisz = new System.Windows.Forms.Button();
            this.PoziomTrudnosci.SuspendLayout();
            this.Bonusy.SuspendLayout();
            this.SuspendLayout();
            // 
            // TerminKolokwium
            // 
            this.TerminKolokwium.Location = new System.Drawing.Point(12, 25);
            this.TerminKolokwium.Name = "TerminKolokwium";
            this.TerminKolokwium.Size = new System.Drawing.Size(144, 20);
            this.TerminKolokwium.TabIndex = 0;
            // 
            // ZaliczenieZaObecnosc
            // 
            this.ZaliczenieZaObecnosc.AutoSize = true;
            this.ZaliczenieZaObecnosc.Location = new System.Drawing.Point(6, 19);
            this.ZaliczenieZaObecnosc.Name = "ZaliczenieZaObecnosc";
            this.ZaliczenieZaObecnosc.Size = new System.Drawing.Size(138, 17);
            this.ZaliczenieZaObecnosc.TabIndex = 0;
            this.ZaliczenieZaObecnosc.Text = "Zaliczenie za obecność";
            this.ZaliczenieZaObecnosc.UseVisualStyleBackColor = true;
            // 
            // WlasneMaterialy
            // 
            this.WlasneMaterialy.AutoSize = true;
            this.WlasneMaterialy.Location = new System.Drawing.Point(6, 42);
            this.WlasneMaterialy.Name = "WlasneMaterialy";
            this.WlasneMaterialy.Size = new System.Drawing.Size(167, 17);
            this.WlasneMaterialy.TabIndex = 1;
            this.WlasneMaterialy.Text = "Można mieć własne materiały";
            this.WlasneMaterialy.UseVisualStyleBackColor = true;
            // 
            // PoziomLatwe
            // 
            this.PoziomLatwe.AutoSize = true;
            this.PoziomLatwe.Location = new System.Drawing.Point(6, 19);
            this.PoziomLatwe.Name = "PoziomLatwe";
            this.PoziomLatwe.Size = new System.Drawing.Size(55, 17);
            this.PoziomLatwe.TabIndex = 0;
            this.PoziomLatwe.TabStop = true;
            this.PoziomLatwe.Text = "Łatwe";
            this.PoziomLatwe.UseVisualStyleBackColor = true;
            // 
            // PoziomTrudnosci
            // 
            this.PoziomTrudnosci.Controls.Add(this.PoziomTrudne);
            this.PoziomTrudnosci.Controls.Add(this.PoziomSrednie);
            this.PoziomTrudnosci.Controls.Add(this.PoziomLatwe);
            this.PoziomTrudnosci.Location = new System.Drawing.Point(12, 120);
            this.PoziomTrudnosci.Name = "PoziomTrudnosci";
            this.PoziomTrudnosci.Size = new System.Drawing.Size(200, 100);
            this.PoziomTrudnosci.TabIndex = 5;
            this.PoziomTrudnosci.TabStop = false;
            this.PoziomTrudnosci.Text = "Poziom trudności";
            // 
            // PoziomTrudne
            // 
            this.PoziomTrudne.AutoSize = true;
            this.PoziomTrudne.Location = new System.Drawing.Point(6, 65);
            this.PoziomTrudne.Name = "PoziomTrudne";
            this.PoziomTrudne.Size = new System.Drawing.Size(59, 17);
            this.PoziomTrudne.TabIndex = 2;
            this.PoziomTrudne.TabStop = true;
            this.PoziomTrudne.Text = "Trudne";
            this.PoziomTrudne.UseVisualStyleBackColor = true;
            // 
            // PoziomSrednie
            // 
            this.PoziomSrednie.AutoSize = true;
            this.PoziomSrednie.Checked = true;
            this.PoziomSrednie.Location = new System.Drawing.Point(6, 42);
            this.PoziomSrednie.Name = "PoziomSrednie";
            this.PoziomSrednie.Size = new System.Drawing.Size(61, 17);
            this.PoziomSrednie.TabIndex = 1;
            this.PoziomSrednie.TabStop = true;
            this.PoziomSrednie.Text = "Średnie";
            this.PoziomSrednie.UseVisualStyleBackColor = true;
            // 
            // Bonusy
            // 
            this.Bonusy.Controls.Add(this.ZaliczenieZaObecnosc);
            this.Bonusy.Controls.Add(this.WlasneMaterialy);
            this.Bonusy.Location = new System.Drawing.Point(12, 51);
            this.Bonusy.Name = "Bonusy";
            this.Bonusy.Size = new System.Drawing.Size(200, 63);
            this.Bonusy.TabIndex = 6;
            this.Bonusy.TabStop = false;
            this.Bonusy.Text = "Bonusy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Termin kolokwium";
            // 
            // PytanieWyciagajace
            // 
            this.PytanieWyciagajace.Location = new System.Drawing.Point(12, 239);
            this.PytanieWyciagajace.Name = "PytanieWyciagajace";
            this.PytanieWyciagajace.Size = new System.Drawing.Size(200, 20);
            this.PytanieWyciagajace.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pytanie \'wyciągające\'";
            // 
            // CzasPisania
            // 
            this.CzasPisania.FormattingEnabled = true;
            this.CzasPisania.Items.AddRange(new object[] {
            "15 minut",
            "30 minut",
            "45 minut ",
            "1 godzina",
            "90 minut"});
            this.CzasPisania.Location = new System.Drawing.Point(12, 281);
            this.CzasPisania.Name = "CzasPisania";
            this.CzasPisania.Size = new System.Drawing.Size(200, 21);
            this.CzasPisania.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Czas pisania";
            // 
            // Wyczysc
            // 
            this.Wyczysc.Image = global::XmlExample.Properties.Resources.panel_button_cancel;
            this.Wyczysc.Location = new System.Drawing.Point(232, 84);
            this.Wyczysc.Name = "Wyczysc";
            this.Wyczysc.Size = new System.Drawing.Size(105, 32);
            this.Wyczysc.TabIndex = 5;
            this.Wyczysc.Text = "Czyść dane";
            this.Wyczysc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Wyczysc.UseVisualStyleBackColor = true;
            this.Wyczysc.Click += new System.EventHandler(this.Wyczysc_Click);
            // 
            // Wczytaj
            // 
            this.Wczytaj.Image = global::XmlExample.Properties.Resources.panel_button_open_file;
            this.Wczytaj.Location = new System.Drawing.Point(232, 46);
            this.Wczytaj.Name = "Wczytaj";
            this.Wczytaj.Size = new System.Drawing.Size(105, 32);
            this.Wczytaj.TabIndex = 4;
            this.Wczytaj.Text = "Wczytaj XML";
            this.Wczytaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Wczytaj.UseVisualStyleBackColor = true;
            this.Wczytaj.Click += new System.EventHandler(this.Wczytaj_Click);
            // 
            // Zapisz
            // 
            this.Zapisz.Image = global::XmlExample.Properties.Resources.panel_buton_save;
            this.Zapisz.Location = new System.Drawing.Point(232, 8);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(105, 32);
            this.Zapisz.TabIndex = 3;
            this.Zapisz.Text = "Zapisz XML";
            this.Zapisz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Zapisz.UseVisualStyleBackColor = true;
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 325);
            this.Controls.Add(this.Wyczysc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CzasPisania);
            this.Controls.Add(this.Wczytaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PytanieWyciagajace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bonusy);
            this.Controls.Add(this.PoziomTrudnosci);
            this.Controls.Add(this.Zapisz);
            this.Controls.Add(this.TerminKolokwium);
            this.Name = "Form1";
            this.Text = "Planowane parametry kolokwium";
            this.PoziomTrudnosci.ResumeLayout(false);
            this.PoziomTrudnosci.PerformLayout();
            this.Bonusy.ResumeLayout(false);
            this.Bonusy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker TerminKolokwium;
        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.CheckBox ZaliczenieZaObecnosc;
        private System.Windows.Forms.CheckBox WlasneMaterialy;
        private System.Windows.Forms.RadioButton PoziomLatwe;
        private System.Windows.Forms.GroupBox PoziomTrudnosci;
        private System.Windows.Forms.RadioButton PoziomTrudne;
        private System.Windows.Forms.RadioButton PoziomSrednie;
        private System.Windows.Forms.GroupBox Bonusy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PytanieWyciagajace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Wczytaj;
        private System.Windows.Forms.ComboBox CzasPisania;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Wyczysc;
    }
}

