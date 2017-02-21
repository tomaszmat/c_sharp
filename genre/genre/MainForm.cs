using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace genre
{
    public partial class MainForm : Form
    {
        
        
        string source;
        public List<string> history = new List<string>();
        public MainForm()
        {
            InitializeComponent();
            buttonHash.Visible = false;
            radioButtonCheckFTB.Checked = true;
        }
        string toHistory;
        string hashedHistory;

        private void buttonHash_Click_1(object sender, EventArgs e)
        {

            if (comboBoxChooseCode.SelectedIndex == 0)
            {
                toHistory = textBoxToH.Text;
                hashedHistory = HashClass.genMD5(textBoxToH.Text);
                textBoxHash.Text = HashClass.genMD5(textBoxToH.Text);
                history.Add(hashedHistory + " is uncoded by MD5: " + toHistory);
            }
            else if (comboBoxChooseCode.SelectedIndex == 1)
            {
                toHistory = textBoxToH.Text;
                hashedHistory = HashClass.genSHA512(textBoxToH.Text);
                textBoxHash.Text = HashClass.genSHA512(textBoxToH.Text);
                history.Add(hashedHistory + " is uncoded by SHA512: " + toHistory);
            }
            else if (comboBoxChooseCode.SelectedIndex == 2)
            {
                toHistory = textBoxToH.Text;
                hashedHistory = HashClass.genSHA1(textBoxToH.Text);
                textBoxHash.Text = HashClass.genSHA1(textBoxToH.Text);
                history.Add(hashedHistory + " is uncoded by SHA1: " + toHistory);
            }
            else if (comboBoxChooseCode.SelectedIndex == 3)
            {
                toHistory = textBoxToH.Text;
                hashedHistory = HashClass.genSHA384(textBoxToH.Text);
                textBoxHash.Text = HashClass.genSHA384(textBoxToH.Text);
                history.Add(hashedHistory + " is uncoded by SHA384: " + toHistory);
            }
            else if (comboBoxChooseCode.SelectedIndex == 4)
            {
                toHistory = textBoxToH.Text;
                hashedHistory = HashClass.genSHA256(textBoxToH.Text);
                textBoxHash.Text = HashClass.genSHA256(textBoxToH.Text);
                history.Add(hashedHistory + " is uncoded by SHA256: " + toHistory);
            }
            else
            {
                MessageBox.Show("You don't choice codeing type!");
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (radioButtonCheckFTB.Checked == true)
            {
               
                if (textBoxHashedText.Text == HashClass.genMD5(textBoxChFTB.Text))
                {
                    MessageBox.Show("OK", "OK");
                }
                else
                    MessageBox.Show("Error", "!!");
            }
            else if (radioButtonChFWL.Checked == true)
            {
                DateTime dt = DateTime.Now;
                string genre;
                string[] lines = System.IO.File.ReadAllLines(source);
                foreach (string how in lines)
                {
                    genre = HashClass.genMD5(how);
                    if (genre == textBoxHashedText.Text)
                    {
                        DateTime exit = DateTime.Now;

                        MessageBox.Show("Password: " + how + Environment.NewLine + "Searching time: " + (exit - dt), "Congratulations!:)", MessageBoxButtons.OK);
                        break;
                    }
                    else
                    {
                        GC.Collect();
                        continue;
                    }
                }
            }
        }

        private void buttonSource_Click(object sender, EventArgs e)
        {
            buttonCheck.Visible = true;
            OpenFileDialog okienko = new OpenFileDialog();
            okienko.Filter = "txt files (txt)|*.txt";
            if (okienko.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Wybrano plik: " + okienko.FileName);
            }
            source = okienko.FileName;
        }

        private void comboBoxChooseCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonHash.Visible = true;
        }

        private void radioButtonCheckFTB_CheckedChanged(object sender, EventArgs e)
        {
            buttonSource.Visible = false;
            buttonCheck.Visible = true;
            textBoxChFTB.Visible = true;
         
        }

        private void radioButtonChFWL_CheckedChanged(object sender, EventArgs e)
        {
            buttonSource.Visible = true;
            buttonCheck.Visible = false;
            textBoxChFTB.Visible = false;

        }

        private void genList()
        {
            char[] charsToTrim = { '0' };
            List<string> lista = new List<string>();
            string[] pass = new string[4];
            string[] lines = System.IO.File.ReadAllLines(link);
            DateTime start = DateTime.Now;
            foreach (string how in lines)
            {
               // MessageBox.Show("Please wait. We genre", "!",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                pass[0] = how;
                pass[1] = how.ToUpper();
                pass[2] = how.ToLower();
                lista.Add(how);
                lista.Add(how.ToLower());
                lista.Add(how.ToUpper());

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 10000; j++)
                    {
                        lista.Add(pass[i].TrimEnd(charsToTrim) + j.ToString());
                        lista.Add(j.ToString() + pass[i].TrimEnd(charsToTrim));
                        lista.Add(j.ToString() + pass[i].TrimEnd(charsToTrim) + (10000 - j));
                        lista.Add(j.ToString() + pass[i].TrimEnd(charsToTrim) + j);

                    }

                    lista.Add(pass[i] + "00000000");
                    lista.Add(pass[i] + "123456789");
                    GC.Collect();
                }

            }
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "txt files (txt)|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllLines(save.FileName, lista);
                DateTime end = DateTime.Now;
                history.Add("Wygenerowano w czasie: " + (end - start) + "a ilosc wygenerowanych hasel wynosi: " + lista.Count + " Dla Pliku: " + link);
                MessageBox.Show("Wygenerowano w czasie: " + (end - start) + "a ilosc wygenerowanych hasel wynosi: " + lista.Count + "Dla Pliku: " + link);
            }
          
            
           
        }
        string link;
        private void buttonGen_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog okienko = new OpenFileDialog();
            okienko.Filter = "txt files (txt)|*.txt";
            if (okienko.ShowDialog() == DialogResult.OK)
            {
                link = okienko.FileName;
                textBoxLink.Text = link;
            }
           
        }


        private void buttonggg_Click(object sender, EventArgs e)
        {
            if (textBoxLink.Text == String.Empty)
            { MessageBox.Show("wybierz lokalizacje pliku!"); }
            else
                genList();
        }

        private void textBoxToH_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

       

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Txt|*.txt";
            save.Title = "Save History";
            save.ShowDialog();
            if (save.FileName != "")
            {
                StreamWriter sw = new StreamWriter(save.FileName);
                foreach (string how in history)
                { sw.WriteLine(how); }
                sw.Close();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
 