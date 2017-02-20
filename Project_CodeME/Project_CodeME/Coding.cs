using System;
using System.Security.Cryptography;
using System.Text;

namespace Project_CodeME
{
    public class Coding
    {
        public static string GetMt5(string charsToHash)
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
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
