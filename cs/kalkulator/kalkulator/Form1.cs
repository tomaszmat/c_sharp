using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class FormCaluclator : Form
    {
        public decimal a;
        public decimal b;
        public decimal c;
        public string x;
        public int y;
        public decimal z;

        public FormCaluclator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double outValue = 1 ;
            bool resultTxt1 = Double.TryParse(textBox1.Text, out outValue);
            //(textBox1.Text != String.Empty) || (textBox2.Text != String.Empty )
            if (resultTxt1 == true )
            {
                a = decimal.Parse(textBox2.Text);
                b = decimal.Parse(textBox1.Text);
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;

                if (radioButton1.Checked)
                {
                    listBox1.Items.Clear();
                    c = a + b;

                    z = Decimal.Round(c, y);
                    listBox1.Items.Clear();
                    listBox1.Items.Add(z);
                }
                else if (radioButton2.Checked)
                {
                    listBox1.Items.Clear();
                    c = a - b;
                    z = Decimal.Round(c, y);
                    listBox1.Items.Clear();
                    listBox1.Items.Add(z);
                }
                else if (radioButton3.Checked)
                {
                    listBox1.Items.Clear();
                    if (b == 0)
                    {
                        string x = "Nie można dzielić przez 0.";
                        string y = "Operacja niedozwolona!";
                        MessageBox.Show(x, y, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        c = a / b;
                        z = Decimal.Round(c, y);
                        listBox1.Items.Clear();
                        listBox1.Items.Add(z);
                    }
                }
                else if (radioButton4.Checked)
                {
                    listBox1.Items.Clear();
                    c = a * b;
                    z = Decimal.Round(c, y);
                    listBox1.Items.Clear();
                    listBox1.Items.Add(z);
                }
            }
            else
            {
                string alert = "Nie wprowadziłeś nic lub wprowadziłeś litere/ciąg liter";
                string main = "Ostrzeżenie!";
                MessageBox.Show(alert, main, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 10;
            trackBar1.ValueChanged += new System.EventHandler(TrackBar1_ValueChanged);

        }

        private void TrackBar1_ValueChanged(object sender, System.EventArgs e)
        {
            x = trackBar1.Value.ToString();
            y = int.Parse(x);

         
        }

    }
}
