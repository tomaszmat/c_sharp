using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using TomaszMatusiakPracaDomowa.View;

namespace TomaszMatusiakPracaDomowa
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;database=pracaDomowaLab3;Trusted_Connection=yes");
        }

        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addWithChoiceWhat();
        }
        private void buttonRead_Click(object sender, EventArgs e)
        {
            readWithChoiceWhat();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Controller.ChangesSQL.deleteWithChoiceWhat(textBoxWhatDelete.Text, radioButtonDepartment.Checked, radioButtonWhoOrdering.Checked, radioButtonID.Checked, radioButtonViewOrderData.Checked);
            deleteWithChoiceWhat(); 
            // chcicalem zrobi funkcje statyczna ale wyskakuje blad opisany w pliku ChangesSQL.cs w folderze Controller.
        } 
        private void addWithChoiceWhat()
        {
            if (radioButtonDepartment.Checked)
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO  Department (DepartmentPlace, DepartmentName, DepartmentPhone) VALUES ('" + textBoxPosition1.Text + "','" + textBoxPoistion2.Text + "','" + textBoxPosition3.Text + "')");
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            else if (radioButtonViewOrderData.Checked)
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO  OrderData (Amount, Supply, PriceOfAmount, PriceSingle) VALUES ('" + textBoxPosition1.Text + "','" + textBoxPoistion2.Text + "','" + textBoxPosition3.Text + "','" + textBoxPosition4.Text + "')");
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            else if (radioButtonWhoOrdering.Checked)
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO  WhoOrdering (DepartmentOrderingID, IfOrderIsVeryImportatnt, OrderDateID) VALUES ('" + textBoxPosition1.Text + "','" + textBoxPoistion2.Text + "','" + textBoxPosition3.Text + "')");
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            else if (radioButtonID.Checked)
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO  ID (Name, Surname, BornDate, BornPlace ) VALUES ('" + textBoxPosition1.Text + "','" + textBoxPoistion2.Text + "','" + textBoxPosition3.Text + "','" + textBoxPosition4.Text + "')");
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        private void readWithChoiceWhat()
        {
            dataGridViewDataShow.DataSource = null;
            if (radioButtonDepartment.Checked)
            {
                sqlDataAdapter = new SqlDataAdapter("Select * from Department", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridViewDataShow.DataSource = dataTable;
            }
            else if (radioButtonViewOrderData.Checked)
            {
                sqlDataAdapter = new SqlDataAdapter("Select * from OrderData", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridViewDataShow.DataSource = dataTable;
            }
            else if (radioButtonID.Checked)
            {
                sqlDataAdapter = new SqlDataAdapter("Select * from ID", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridViewDataShow.DataSource = dataTable;
            }
            else if (radioButtonWhoOrdering.Checked)
            {
                sqlDataAdapter = new SqlDataAdapter("Select * from WhoOrdering", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridViewDataShow.DataSource = dataTable;
            }
        }
        private void deleteWithChoiceWhat()
        {
            // tutaj powinno byc jeszcze TryParse aby program byl "idiotoodporny"
            if (radioButtonDepartment.Checked)
            {
                int x = Int32.Parse(textBoxWhatDelete.Text);
                SqlCommand sqlCommand = new SqlCommand("Delete Department where ID = '" + x + "'");
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            else if (radioButtonWhoOrdering.Checked)
            {
                int x = Int32.Parse(textBoxWhatDelete.Text);
                SqlCommand sqlCommand = new SqlCommand("Delete WhoOrdering where ID = '" + x + "'");
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            else if (radioButtonID.Checked)
            {
                int x = Int32.Parse(textBoxWhatDelete.Text);
                SqlCommand sqlCommand = new SqlCommand("Delete ID where ID = '" + x + "'");
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            else if (radioButtonViewOrderData.Checked)
            {
                int x = Int32.Parse(textBoxWhatDelete.Text);
                SqlCommand sqlCommand = new SqlCommand("Delete OrderData where ID = '" + x + "'");
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        private void buttonView2_Click(object sender, EventArgs e)
        {
            FormShowAnotherView formShowView2 = new FormShowAnotherView();
            formShowView2.ShowDialog();

        }

        private void buttonView1_Click_1(object sender, EventArgs e)
        {
            formShow formShow = new formShow();
            formShow.ShowDialog();
        }

        private void buttonView3_Click(object sender, EventArgs e)
        {
            FormShowAnotherView formShowView3 = new FormShowAnotherView();
            formShowView3.ShowDialog();
        }
    }
}
