using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TomaszMatusiakPracaDomowa.View
{
    public partial class FormShowAnotherView : Form
    {
        public FormShowAnotherView()
        {
            InitializeComponent();
            readSQL();
        }

        public void readSQL()
        {
            SqlConnection sqlConnection;
            SqlDataAdapter sqlDataAdapter;
            //dataGridViewFormShow
            string connection = "Data Source=.\\SQLEXPRESS;database=pracaDomowaLab3;Trusted_Connection=yes";
            sqlConnection = new SqlConnection(connection);
            sqlDataAdapter = new SqlDataAdapter("Select * from ViewSecond", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewAnotherShowForm.DataSource = dataTable;
        }
    }
}
