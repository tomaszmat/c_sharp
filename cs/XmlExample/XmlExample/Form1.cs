using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XmlExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            Konfiguracja k = new Konfiguracja();
            k.PoziomTrudnosci = 0;
            if (this.PoziomLatwe.Checked) k.PoziomTrudnosci = 1;
            if (this.PoziomSrednie.Checked) k.PoziomTrudnosci = 2;
            if (this.PoziomTrudne.Checked) k.PoziomTrudnosci = 3;
            k.PytanieWyciagajace = this.PytanieWyciagajace.Text;
            k.WlasneMaterialy = this.WlasneMaterialy.Checked;
            k.ZaliczenieZaObecnosc = this.ZaliczenieZaObecnosc.Checked;
            k.TerminKolokwium = this.TerminKolokwium.Value;
            k.CzasPisania = (string)this.CzasPisania.Text;

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Pliki XML (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
            dlg.DefaultExt = "xml";
            dlg.FileName = "Kolokwium.xml";
            if(DialogResult.OK == dlg.ShowDialog())
                Konfiguracja.Serialize(dlg.FileName, k);
        }


        private void Wczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Pliki XML (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
            dlg.DefaultExt = "xml";
            dlg.FileName = "Kolokwium.xml";
            if (DialogResult.OK == dlg.ShowDialog())
            {
                Konfiguracja k = Konfiguracja.Deserialize(dlg.FileName);
                switch(k.PoziomTrudnosci)
                {
                    case 1: PoziomLatwe.Checked = true; break;
                    case 2: PoziomSrednie.Checked = true; break;
                    case 3: PoziomTrudne.Checked = true; break;
                }
                this.PytanieWyciagajace.Text = k.PytanieWyciagajace;
                this.WlasneMaterialy.Checked = k.WlasneMaterialy;
                this.ZaliczenieZaObecnosc.Checked = k.ZaliczenieZaObecnosc;
                this.TerminKolokwium.Value = k.TerminKolokwium;
                this.CzasPisania.Text = k.CzasPisania;
            }
        }

        private void Wyczysc_Click(object sender, EventArgs e)
        {
            PoziomLatwe.Checked = false;
            PoziomSrednie.Checked = true;
            PoziomTrudne.Checked = false;
            PytanieWyciagajace.Text = "";
            WlasneMaterialy.Checked = false;
            ZaliczenieZaObecnosc.Checked = false;
            CzasPisania.Text = "";
            TerminKolokwium.Value = DateTime.Now;
        }
    }
}
