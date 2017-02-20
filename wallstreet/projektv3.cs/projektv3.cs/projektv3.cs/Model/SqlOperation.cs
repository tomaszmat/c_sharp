using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace FormHello.cs
{
    public static class SqlOperation
    {
        #region Zapisywanie notowań do bazy danych.
        public static void SqlSave(List<ThreadsTimer.Interest[]> interestList, int k)
        {//zapis notowan
               //SqlConnection sqlConnection;
               //string connectionString = "Data Source=.\\SQLEXPRESS;database=New Database;Trusted_Connection=yes";
               //sqlConnection = new SqlConnection(connectionString);
               // for (int i = 0; i < 4; i++)
               // {
               //     SqlCommand sqlCommand = new SqlCommand("INSERT INTO InterestTable (InterestName,InterestValue, DateTime) VALUES('" + interestList[k][i].nameOfInterst + "', '" + interestList[k][i].valueOfInterest + "', '" + DateTime.Now + "')");
               //     sqlCommand.Connection = sqlConnection;
               //     sqlConnection.Open();
               //     sqlCommand.ExecuteNonQuery();
               //     sqlConnection.Close();
               // }
        }
        #endregion
        #region Aktualizacja stanu użytkownika. Wywołanie tej funkcji poprzedzone sie usunięciem użytkownika z bazy.
        public static void Actualization(string username,string password, decimal value, int actionAmount, int debenturesAmount, int balancedMarketAmount, int moneyMarketAmount)
        {//zapis 10 sekund stanu zalogowanego użytkownika
            SqlConnection sqlConnection;
            string connectionString = "Data Source=.\\SQLEXPRESS;database=New Database;Trusted_Connection=yes";
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO LogReg (Username,Password, Wallet, ActionAmount, MoneyMarketAmount, BalancedMarket, DebenturesAmount  ) VALUES('" + username + "', '" + password + "', '" + value + "', '" + actionAmount + "', '" + moneyMarketAmount + "', '" + balancedMarketAmount + "','"+debenturesAmount+"')");
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
        #region Usuwanie użtykownika z bazy.
        public static void DeletePosition(string username)
        {/*usunięcie ostatniego stanu użytkownika tj. przejecie części jego danych w tym haslo do logowania
          * przez funkcje akutalizującą
          */
            SqlConnection sqlConnection;
            string connectionString = "Data Source=.\\SQLEXPRESS;database=New Database;Trusted_Connection=yes";
            sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand= new SqlCommand("DELETE LogReg where Username ='"+username+"' ");
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        #endregion
        #region Pokazywanie listy użytkowników których można okraść.
        public static void GetUsersList(System.Windows.Forms.DataGridView dataGridViewUserList)
        {
            //string connectionString = "Data Source=.\\SQLEXPRESS;database=New Database;Trusted_Connection=yes";
            //SqlDataAdapter sqlDataAdapter;
            //SqlConnection sqlConnection;
            //sqlConnection = new SqlConnection(connectionString);
            //sqlDataAdapter = new SqlDataAdapter("Select * from ViewUserList ", sqlConnection);
            //DataTable dataTable = new DataTable();
            //sqlDataAdapter.Fill(dataTable);
            //dataGridViewUserList.DataSource = dataTable;
        }
        #endregion

    }
}
