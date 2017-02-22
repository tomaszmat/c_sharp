using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseTest
{
    public partial class FormDataShow : Form
    {
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;

        public FormDataShow()
        {
            InitializeComponent();
            // localhost - nazwa serwera bazy danych też np. .\sqlexpress etc...
            // ImieNazwiskoLab3Zad2 - nazwa bazy danych
            sqlConnection = new SqlConnection("Data Source=localhost;database=ImieNazwiskoLab3Zad2;Trusted_Connection=yes");
        }

        /// <summary>
        /// Zdarzenie obsługujące pobieranie danych z bazy przy użyciu zapytania select
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            dataGridViewDataShow.DataSource = null;
            // Do zapytań można oczywiście dodać warunek where lub utworzyć join
            // Student - przykładowa nazwa tabeli
            sqlDataAdapter = new SqlDataAdapter("Select * from Student", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewDataShow.DataSource = dataTable;
        }

        /// <summary>
        /// Zdarzenie obsługujące zapytania przy użyciu SqlCommand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSampleInsert_Click(object sender, EventArgs e)
        {
            // Student - przykładowa nazwa tabeli
            // values ('Jan','Kos','123456',1,null,null) - przykładowe wartości
            SqlCommand sqlCommand = new SqlCommand("Insert into Student values ('Jan','Kos','123456',1,null,null)");
            // Przy użyciu sqlCommand można stosować także komendy usuwające dane lub uaktualniające np.
            // SqlCommand sqlCommand = new SqlCommand("Delete Student where name= 'Jan'");

            // Można też oczywiście wstawiać wartości z innych pól do zapytań np. Insert into Student values ('"+textBoxTest.Text+"','Kos','123456',1,null,null)" etc..
            
            sqlCommand.Connection = sqlConnection;
            
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
