using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace connectingsql
{
    public partial class Form1 : Form
    {
        public string sendAsRequest;
    
        public Form1()
        {
            InitializeComponent();
            
        }
      
        private SqlConnection polaczenie;

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            polaczenie = new SqlConnection();
            polaczenie.ConnectionString = "Data Source=BLUEMANN-DELL\\SQLEXPRESS;Initial Catalog=databaseone;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            try
            {
               polaczenie.Open();
                MessageBox.Show("Connection Open ! ");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

          
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                polaczenie.Close();
                MessageBox.Show("Connection Close ! ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can close connection ! ");
            }
        }

        private void buttonAddPos_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sendAsRequest = hashingPass(rnd.ToString());
            string command = "INSERT INTO dupa (Id, FirstName, SecondName) VALUES(12, 'Jan', '"+sendAsRequest+"')";
            SqlCommand sqlCommand = new SqlCommand(command);
            sqlCommand.Connection = polaczenie;
             sqlCommand.ExecuteNonQuery();
            dataGridViewInfo.DataSource = pobierz_dane("select * from dupa");


        }
        private string hashingPass(string unhashPass)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(unhashPass);
            data = x.ComputeHash(data);
            string ret = "";
            for (int i = 0; i < data.Length; i++)
                ret += data[i].ToString("x2").ToLower();
            return ret;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public DataTable pobierz_dane(string q)
        {
            DataTable dt = new DataTable(); // deklaracja i utworzenie instancji obiektu DataTable o nazwie dt
            SqlDataReader dr; // deklaracja obiektu SqlDataReader o nazwie dr
            SqlCommand sqlc; // Deklaracja obiektu SqlCOmmand
            sqlc = new SqlCommand(q);
            // utworzenie instancji SQLCommand ktora ma wykonac zapytanie podane jako parametr
            // w zmiennej q
            sqlc.Connection = this.polaczenie; // wskazanie polaczenia do bazy danych
            dr = sqlc.ExecuteReader(); //wykonanie zapytanie i utworzenie wskaznika dr
            dt.Load(dr); //zaladowanie danych do obiektu DataTAble
            return dt; // zwrocenie danych

        }
    }
}
