using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormHello.cs;
using System.Data.SqlClient;
using FormHello.cs.Controller;

namespace ThreadsTimer
{
     public partial class FormRegister : Form
     {
         #region Konstruktor bezparametrowy klasy FormRegister.
         public FormRegister()
        {
            InitializeComponent();  
        }
            #endregion
         #region Logowanie
         private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == String.Empty || textBoxPassword.Text == String.Empty)
            {
                Comunicats.WarringNothingWrite();
            }
            else
            {
                try
                {
                    SqlConnection sqlConnection;
                    string connection = "Data Source=.\\SQLEXPRESS;database=New Database;Trusted_Connection=yes";
                    sqlConnection = new SqlConnection(connection);
                    SqlCommand sqlCommand = new SqlCommand("select * from LogReg where Username = '" + textBoxUsername.Text + "' and Password = '" + textBoxPassword.Text + "'");
                    sqlCommand.Connection = sqlConnection;
                    sqlConnection.Open();
                    SqlDataReader dr = sqlCommand.ExecuteReader();
                    if (dr.Read())
                    {
                        int actionAmount = Convert.ToInt32(dr.GetString(3));
                        int debenturesAmount = Convert.ToInt32(dr.GetString(6));
                        int balancedMarketAmount = Convert.ToInt32(dr.GetString(4));
                        int moneyMarketAmount =  Convert.ToInt32(dr.GetString(5));
                        decimal wallet =Convert.ToDecimal( dr.GetString(2));
                        //powyżej wczytywanie wartości, które zakupiliśmy w poprzednim logowaniu
                        Comunicats.LogHello(textBoxUsername.Text);
                        FormInterest formInterest = new FormInterest(textBoxUsername.Text, textBoxPassword.Text, actionAmount, debenturesAmount, balancedMarketAmount, moneyMarketAmount, wallet);
                        formInterest.ShowDialog();
                        textBoxUsername.Clear();//czyszczenie textBoxów, aby po zamknięciu FormInterest, były puste
                        textBoxPassword.Clear();
                    }
                    else
                    {
                        Comunicats.WrongPassOrLog();
                    }
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
#endregion
         #region Zamknięcie okna.
         private void buttonCancel_Click(object sender, EventArgs e)
        {//wyjście
            Close();
        }
#endregion
         #region Rejestracja nowego użytkownika.
         private void buttonRegisterStart_Click(object sender, EventArgs e)
        {//rejestracja
            if (textBoxUsername.Text == String.Empty || textBoxPassword.Text == String.Empty)
            {
                Comunicats.FailureText();
            }
            else if (textBoxPassword.TextLength < 7)
            {//Wymaganie, aby hasło miało conajmniej 7 znaków.
                textBoxPassword.Clear();
                Comunicats.TooShortPass();
            }
            else
            {
                try
                {
                    SqlConnection sqlConnection;
                    string connection = "Data Source=.\\SQLEXPRESS;database=New Database;Trusted_Connection=yes";
                    sqlConnection = new SqlConnection(connection);
                    SqlCommand sqlCommand = new SqlCommand("select * from LogReg where Username = '" + textBoxUsername.Text + "'");
                    sqlCommand.Connection = sqlConnection;
                    sqlConnection.Open();
                    SqlDataReader dr = sqlCommand.ExecuteReader();
                    if (dr.Read())
                    {
                        Comunicats.UserExist();
                    }
                    else
                    {
                        Comunicats.RegisterHello(textBoxUsername.Text);
                        FormInterest formInterest = new FormInterest(textBoxUsername.Text, textBoxPassword.Text, 0, 0, 0, 0, 10000M);
                        formInterest.Show();
                        //SqlSaver.SqlRegister(textBoxUsername.Text, textBoxPassword.Text);
                        textBoxUsername.Clear();
                        textBoxPassword.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
