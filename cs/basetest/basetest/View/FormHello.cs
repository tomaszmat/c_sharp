using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TomaszMatusiakPracaDomowa
{
    public partial class FormHello : Form
    {
        public FormHello()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            //zapisuje nazwe uzytkownika i haslo do bazy, bez zadnych uwierztylnien
            string name = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            SqlConnection sqlConnection;
            string connection = "Data Source=.\\SQLEXPRESS;database=pracaDomowaLab3;Trusted_Connection=yes";
            sqlConnection = new SqlConnection(connection);
            SqlCommand sqlCommand0 = new SqlCommand("INSERT INTO UserTable (Username,Password) VALUES('"+name+ "', '" +password+ "')");
            sqlCommand0.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand0.ExecuteNonQuery();
            sqlConnection.Close();
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
