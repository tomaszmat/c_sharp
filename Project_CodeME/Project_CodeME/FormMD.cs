using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Project_CodeME
{
    public partial class FormMD : Form
    {
        public FormMD()
        {
            InitializeComponent();
        }
        MD5 md5Hash = MD5.Create();
        private void buttonGenre_Click(object sender, EventArgs e)
        {
            textBoxGeneratedHash.Text = GetMd5Hash(md5Hash, textBoxToGenre.Text);
        }
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string toCheck = GetMd5Hash(md5Hash, textBoxCheckUnHash.Text);
            if (toCheck == textBoxCheckHash.Text)
            { MessageBox.Show("They are the same"); }
            else
            {
                MessageBox.Show("Not the same");
            }

        }
    }
}
