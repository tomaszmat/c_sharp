using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace BlueHash
{
    public partial class FormMT : Form
    {

        public FormMT()
        {
            InitializeComponent();

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

        static string GetMt5(string charsToHash)
        {
            MD5 md5Hash = MD5.Create();
            string hashedPassword = GetMd5Hash(md5Hash, charsToHash);
            Random oneOrTwo = new Random();
            int caseSwitch = oneOrTwo.Next(0, 6);
            switch (caseSwitch)
            {
                case 1:
                    hashedPassword = "49jTB0" + hashedPassword + "a3Rqwt7";
                    break;
                case 2:
                    hashedPassword = "7iQW32" + hashedPassword + "5gDr6cV";
                    break;
                case 3:
                    hashedPassword = "hK1iZ8" + hashedPassword + "PemQ7f1";
                    break;
                case 4:
                    hashedPassword = "pOE09g" + hashedPassword + "y83KsvK";
                    break;
                case 5:
                    hashedPassword = "pOE09g" + hashedPassword + "7iQW32";
                    break;
            }
            string ultrapass = GetMd5Hash(md5Hash, hashedPassword);
            return ultrapass;

        }



        private void buttonGenre_Click_1(object sender, EventArgs e)
        {
            textBoxGeneratedHash.Text = GetMt5(textBoxToGenre.Text);
        }

        private void buttonCheck_Click_1(object sender, EventArgs e)
        {
            int x = 0;
            MD5 md5Hash = MD5.Create();
            string firstMD5 = GetMd5Hash(md5Hash, textBoxCheckUnHash.Text);
            string[] hash = new string[7];
            hash[0] = "49jTB0" + firstMD5 + "a3Rqwt7";
            hash[1] = "7iQW32" + firstMD5 + "5gDr6cV";
            hash[2] = "hK1iZ8" + firstMD5 + "PemQ7f1";
            hash[3] = "pOE09g" + firstMD5 + "y83KsvK";
            hash[4] = "pOE09g" + firstMD5 + "7iQW32";
            string[] hashToCheck = new string[7];
            for (int i = 0; i < 5; i++)
            {
                hashToCheck[i] = GetMd5Hash(md5Hash, hash[i]);
                if (hashToCheck[i] == textBoxCheckHash.Text)
                { x++; }
            }
            if (x > 0)
                MessageBox.Show("That's hash is good.");
            else
                MessageBox.Show("Error. The hash is bad or chars are different");
        }
    }
}
