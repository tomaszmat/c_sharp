using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

using System.Windows.Forms;

namespace Project_CodeME
{
    public partial class FormGenre : Form
    {
        string pass;
        public FormGenre()
        {
            InitializeComponent();
            radioButtonMB5.Checked = false;
            radioButtonMD5.Checked = false;
            labelYouAreLogged.Text = Environment.MachineName;
        }
        private void buttonGenre_Click(object sender, EventArgs e)
        {
            if(textBoxHowLong.Text == String.Empty)
            { MessageBox.Show("Write how long"); }
            if (comboBoxAplha.SelectedIndex == 0)
            {
                pass = RandomString(Int32.Parse(textBoxHowLong.Text));
                textBoxGeneratedHash.Text = pass;
            }
            else if(comboBoxAplha.SelectedIndex == 1)
                {
                pass = WithoutRandomString(Int32.Parse(textBoxHowLong.Text));
                textBoxGeneratedHash.Text = pass;
            }
        }
        public static string RandomString(int range)
        {
            var chars = "abcdefghijklmnopqrstuwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+~`'";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, range)
                            .Select(s => s[random.Next(s.Length)])
                            .ToArray());

            return result;
        }
        public static string WithoutRandomString(int range)
        {
            var chars = "abcdefghijklmnopqrstuwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, range)
                            .Select(s => s[random.Next(s.Length)])
                            .ToArray());

            return result;
        }

        private void buttonGuid_Click(object sender, EventArgs e)
        {
            textBoxGeneratedHash.Text = GuidString(32);
        }
        public static string GuidString(int numOfCharsNeeded)
        {
            if (numOfCharsNeeded <= 32)
                return Guid.NewGuid().ToString("n").Substring(0, numOfCharsNeeded);
            else
            {
                int f = numOfCharsNeeded / 32 + 1;
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i <= f; i++)
                {
                    sb.Append(Guid.NewGuid().ToString("n"));
                }

                return sb.ToString().Remove(numOfCharsNeeded);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MD5 md5Hash = MD5.Create();
            if (radioButtonMB5.Checked == true)
            { textBoxGeneratedHash.Text = Coding.GetMt5(textBoxToGenre.Text); }
            else if (radioButtonMD5.Checked == true)
            { textBoxGeneratedHash.Text = Coding.GetMd5Hash(md5Hash, textBoxToGenre.Text); }
            else
            { MessageBox.Show("Check radiobutton"); }
        }
    }
}
