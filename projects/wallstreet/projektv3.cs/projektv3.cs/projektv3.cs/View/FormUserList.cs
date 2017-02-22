using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FormHello.cs.Controller;
using System.Data.SqlClient;
using System.Windows.Forms;
using ThreadsTimer;

namespace FormHello.cs.View
{
    public partial class FormUserList : Form
    {
        FormInterest interest;
        #region Konstruktor klasy FormUserList
        public FormUserList(Form parent)
        {// konstruktor z parametrami
            InitializeComponent();
            //SqlOperation.GetUsersList(dataGridViewUserList);
            SqlOperation.GetUsersList(dataGridViewUserList);
            interest = (FormInterest)parent; 
        }
        #endregion
        #region Zamknięcie okna.
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Zdarzenie: klikniecie przycisku dokonującego kradzieży.
        private void buttonDoThieft_Click(object sender, EventArgs e)
        {//tymczasowe zmienne, odczytywane z bazy, zanim nieaktualny stan użytkownika zostanie usunięty
            string temporaryPass;
            decimal temporaryWallet;
            SqlConnection sqlConnection;
            string connection = "Data Source=.\\SQLEXPRESS;database=Interest;Trusted_Connection=yes";
            sqlConnection = new SqlConnection(connection);
            SqlCommand sqlCommand = new SqlCommand("select * from LogReg where Username = '" + textBoxUserToThieft.Text + "'");
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                temporaryPass = dr.GetString(1);
                temporaryWallet = Convert.ToDecimal(dr.GetString(2));// trzeba takim sposobem niestety. nie da się bezpośrednio "GetDecimal" bo wyskakuje błąd rzutowania.
                int temporaryAction= Convert.ToInt32(dr.GetString(3));
                int temporaryDebenturesAmount = Convert.ToInt32(dr.GetString(6));
                int temporaryBalancedMarketAmount = Convert.ToInt32(dr.GetString(5));
                int  temporaryMarketAmount = Convert.ToInt32(dr.GetString(4));
                       
                if (radioButtonAction.Checked)
                {
                SqlOperation.DeletePosition(textBoxUserToThieft.Text);
                SqlOperation.Actualization(textBoxUserToThieft.Text, temporaryPass, temporaryWallet, 0, temporaryDebenturesAmount, temporaryBalancedMarketAmount, temporaryMarketAmount);
                interest.actionAmount += temporaryAction;
                }
                else if (radioButtonBalancedMarket.Checked)
                {
                    SqlOperation.DeletePosition(textBoxUserToThieft.Text);
                    SqlOperation.Actualization(textBoxUserToThieft.Text, temporaryPass, temporaryWallet, temporaryAction, temporaryDebenturesAmount, 0, temporaryMarketAmount);
                    interest.balancedMarketAmount += temporaryBalancedMarketAmount;
                }
                else if (radioButtonDebentures.Checked)
                {
                    SqlOperation.DeletePosition(textBoxUserToThieft.Text);
                    SqlOperation.Actualization(textBoxUserToThieft.Text, temporaryPass, temporaryWallet, temporaryAction, 0, temporaryBalancedMarketAmount, temporaryMarketAmount);
                    interest.debenturesAmount += temporaryDebenturesAmount;
                }
                else if (radioButtonMoneyMarket.Checked)
                {
                    SqlOperation.DeletePosition(textBoxUserToThieft.Text);
                    SqlOperation.Actualization(textBoxUserToThieft.Text, temporaryPass, temporaryWallet, temporaryAction, temporaryDebenturesAmount, temporaryBalancedMarketAmount, 0);
                    interest.moneyMarketAmount += temporaryMarketAmount;
                }
          
                MessageBox.Show("Okradłeś: " + textBoxUserToThieft.Text + ". \nŚledczy maja Cię na oku!");
                sqlConnection.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("nie ma takiego użytkownika");
            }

        }
        #endregion
    }
}
