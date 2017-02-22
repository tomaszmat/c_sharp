using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace TomaszMatusiakPracaDomowa.Controller
{
    //public static class ChangesSQL
    //{
    //    // wyskakuje blad "use of unassigned local variable 'sqlConnection 'itd
    //    public static void deleteWithChoiceWhat(string text, bool checked1, bool checked2, bool checked3, bool checked4)
    //    {
    //        SqlConnection sqlConnection;
    //        // tutaj powinno byc jeszcze TryParse aby program byl "idiotoodporny"
    //        if (checked1)
    //        {
                
    //            int x = Int32.Parse(text);
    //            SqlCommand sqlCommand = new SqlCommand("Delete Department where ID = '" + x + "'");
    //            sqlCommand.Connection = sqlConnection;
    //            sqlConnection.Open();
    //            sqlCommand.ExecuteNonQuery();
    //            sqlConnection.Close();
    //        }
    //        else if (checked2)
    //        {
    //            SqlConnection sqlConnection2;
    //            int x = Int32.Parse(text);
    //            SqlCommand sqlCommand = new SqlCommand("Delete WhoOrdering where ID = '" + x + "'");
    //            sqlCommand.Connection = sqlConnection2;
    //            sqlConnection2.Open();
    //            sqlCommand.ExecuteNonQuery();
    //            sqlConnection2.Close();
    //        }
    //        else if (checked3)
    //        {
    //            SqlConnection sqlConnection3;
    //            int x = Int32.Parse(text);
    //            SqlCommand sqlCommand = new SqlCommand("Delete ID where ID = '" + x + "'");
    //            sqlCommand.Connection = sqlConnection3;
    //            sqlConnection3.Open();
    //            sqlCommand.ExecuteNonQuery();
    //            sqlConnection3.Close();
    //        }
    //        else if (checked4)
    //        {
    //            SqlConnection sqlConnection4;
    //            int x = Int32.Parse(text);
    //            SqlCommand sqlCommand = new SqlCommand("Delete OrderData where ID = '" + x + "'");
    //            sqlCommand.Connection = sqlConnection4;
    //            sqlConnection4.Open();
    //            sqlCommand.ExecuteNonQuery();
    //            sqlConnection4.Close();
    //        }
    //    }
    //}
}
