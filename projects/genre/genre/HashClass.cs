using System.Security.Cryptography;
using System.Text;

namespace genre
{
    public static class HashClass
    {
        public static string genMD5(string input)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(input));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 1; i < result.Length; i++)
            {
                str.Append(result[i].ToString("X2"));
            }
            return str.ToString();

        }

        public static string genSHA512(string data)
        {
            byte[] result;
            SHA512 shaM = new SHA512Managed();
            result = shaM.ComputeHash(ASCIIEncoding.ASCII.GetBytes(data));
            StringBuilder str = new StringBuilder();
            for (int i = 1; i < result.Length; i++)
            {
                str.Append(result[i].ToString("X2"));
            }
            return str.ToString();
        }
        public static string genSHA1(string data)
        {
            byte[] result;
            SHA1 sha = new SHA1CryptoServiceProvider(); ;
            result = sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(data));
            StringBuilder str = new StringBuilder();
            for (int i = 1; i < result.Length; i++)
            {
                str.Append(result[i].ToString("X2"));
            }
            return str.ToString();
        }

        public static string genSHA384(string data)
        {
            byte[] result;
            SHA384 sha = new SHA384Managed();
            result = sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(data));
            StringBuilder str = new StringBuilder();
            for (int i = 1; i < result.Length; i++)
            {
                str.Append(result[i].ToString("X2"));
            }
            return str.ToString();
        }
        public static string genSHA256(string data)
        {
            byte[] result;
            SHA256 sha = new SHA256Managed();
            result = sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(data));
            StringBuilder str = new StringBuilder();
            for (int i = 1; i < result.Length; i++)
            {
                str.Append(result[i].ToString("X2"));
            }
            return str.ToString();
        }
    }
}
