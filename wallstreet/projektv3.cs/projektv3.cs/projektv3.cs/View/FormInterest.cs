using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using FormHello.cs;
using FormHello.cs.View;
using FormHello.cs.Controller;


namespace ThreadsTimer
{
    public partial class FormInterest : Form
    {
        #region Atrybuty klasy.
        int thieftCounter = 0; // licznik otwarcia okna
        decimal transferValue;//wartość transakcji
        private string username;// nazwa użytkownika
        private string password;//hasło dla danego użytkownika
        private decimal valueWalletUser;//wartość portfela użytkownika
        int k; //inkrementacja co 10s (timerInterest)
        //poniżej deklaracje wartośści poszczególnych podmiotów do kupienia
        public int actionAmount, debenturesAmount, balancedMarketAmount, moneyMarketAmount;
        protected decimal tax;// opłata pobierana przy sprzedaży podmiotów
        Interest[] interestOnePosition;
        List<Interest[]> interestList = new List<Interest[]>();
        #endregion
        #region Konstruktor okna notowań oraz wywołanie odpowiednich funkcji inicjalizujących.
        public FormInterest(string username, string password, int actionAmount, int debenturesAmount, int balancedMarketAmount, int moneyMarketAmount, decimal valueWalletUser)
        {
            InitializeComponent();
            this.valueWalletUser = valueWalletUser;
            this.actionAmount = actionAmount;
            this.debenturesAmount = debenturesAmount;
            this.balancedMarketAmount = balancedMarketAmount;
            this.moneyMarketAmount = moneyMarketAmount;
            this.username = username;
            this.password = password;
            InterestStart();
            timerInterest.Start();
            labelThieftCounter.Text = thieftCounter.ToString();
            progressBarInterest.Minimum = 1;
            progressBarInterest.Maximum = 10;
            labelUsername.Text = username;
            timerProgress.Start();
        }
        #endregion
        #region Przycik wywołania kupna.
        private void buttonBuy_Click(object sender, EventArgs e)
        {
           Buying();
        }
        #endregion
        #region Przycisk wywołania sprzedaży.
        private void buttonSell_Click(object sender, EventArgs e)
        {
            Selling();
        }
        #endregion
        #region Wyjście z aplikacji.
        private void buttonCancel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion 
        #region TimerInterest, wywołuje dalsze notowania co 10s. + odświeżanie co 10 sekund licznika otwarcia okna do kradzieży.
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (thieftCounter == 5)
            {
                Comunicats.TooMuchThieft();
                this.Close();
            }
            else
            {
                k++;
                InterestContinue(k);
                SqlOperation.SqlSave(interestList, k);
                progressBarInterest.Value = 1;
                SqlOperation.DeletePosition(username);//aktualizacja stanu zalogowanego użytkownika
                SqlOperation.Actualization(username, password, valueWalletUser, actionAmount, debenturesAmount, balancedMarketAmount, moneyMarketAmount); 
            }
        }
        #endregion
        #region  Funkcja rozpoczynająca ( w konstruktorze, wywolana tylko raz przy otwraciu okna) notowania po zalogowaniu się(przyjęcie pewnych warunków początkowych).
        private void InterestStart()
        {
            interestOnePosition = new Interest[4];
            interestOnePosition[0] = new Interest(-90, 120, "Akcje", 300);
            interestOnePosition[1] = new Interest(-10, 50, "Obligacje", 300);
            interestOnePosition[2] = new Interest(-5, 20, "Rynek pieniężny", 300);
            interestOnePosition[3] = new Interest(-3, 70, "Rynek zrównoważony", 300);
            interestList.Add(interestOnePosition);
            dataGridViewInterest.Rows.Add(interestList[0][0].nameOfInterst, interestList[0][0].valueOfInterest, interestList[0][0].percentOfInterest * 100 + "%", DateTime.Now);
            dataGridViewInterest.Rows.Add(interestList[0][1].nameOfInterst, interestList[0][1].valueOfInterest, interestList[0][1].percentOfInterest * 100 + "%", DateTime.Now);
            dataGridViewInterest.Rows.Add(interestList[0][2].nameOfInterst, interestList[0][2].valueOfInterest, interestList[0][2].percentOfInterest * 100 + "%", DateTime.Now);
            dataGridViewInterest.Rows.Add(interestList[0][3].nameOfInterst, interestList[0][3].valueOfInterest, interestList[0][3].percentOfInterest * 100 + "%", DateTime.Now);
        }
        #endregion
        #region Funkcja sprzedająca, sprawdzenie warunków i diagramu możliwości.
        private void Selling()
        {
            int outValue = 1;
            bool ifInt = Int32.TryParse(textBoxHow.Text, out outValue);
            Object thisLock = new Object();
            /*
             * "thisLock" służy do zablokowania możliwości zmiany zmiennej, gdy klikneliśmy, któryś przycisk
             * transakcji w momencie upływu 10sek i zmiany wartości notowań.
             */
            if (ifInt == true)
            {
                int amountTransfer = Convert.ToInt32(textBoxHow.Text);
                if (amountTransfer == 0)
                {
                    Comunicats.WarringCantDoIt();
                }
                else
                {
                    if (radioButtonAction.Checked)
                    {
                        if (amountTransfer > actionAmount)
                        {
                            Comunicats.WarringErrorSupply();
                        }
                        else
                        {
                            lock (thisLock)
                            {
                                tax = Decimal.Round(((decimal)amountTransfer * interestList[k][0].valueOfInterest * (decimal)0.02), 2);
                                transferValue = ((decimal)amountTransfer * interestList[k][0].valueOfInterest )- tax;
                                valueWalletUser = valueWalletUser + transferValue;
                                actionAmount -= amountTransfer;
                            }
                            AddStringListBox.SellingAddStringToListBox(interestList[k][0].nameOfInterst,listBoxInterest, transferValue, valueWalletUser, tax);
                        }
                    }
                    else if (radioButtonDebentures.Checked)
                    {
                        if (amountTransfer > debenturesAmount)
                        {
                            Comunicats.WarringErrorSupply();
                        }
                        else
                        {
                            lock (thisLock)
                            {
                                tax = Decimal.Round(((decimal)amountTransfer * interestList[k][1].valueOfInterest * (decimal)0.02), 2);
                                transferValue = (decimal)amountTransfer * interestList[k][1].valueOfInterest - tax;
                                valueWalletUser -= transferValue; debenturesAmount -= amountTransfer;
                            }
                            AddStringListBox.SellingAddStringToListBox(interestList[k][1].nameOfInterst, listBoxInterest, transferValue, valueWalletUser, tax);
                        }
                    }
                    else if (radioButtonMoneyMarket.Checked)
                    {
                        if (amountTransfer > balancedMarketAmount)
                        {
                            Comunicats.WarringErrorSupply();
                        }
                        else
                        {
                            lock (thisLock)
                            {
                                tax = Decimal.Round(((decimal)amountTransfer * interestList[k][2].valueOfInterest * (decimal)0.02), 2);
                                transferValue = (decimal)amountTransfer * interestList[k][2].valueOfInterest - tax;
                                valueWalletUser -= transferValue; balancedMarketAmount -= amountTransfer;
                            }
                            AddStringListBox.SellingAddStringToListBox(interestList[k][2].nameOfInterst, listBoxInterest, transferValue, valueWalletUser, tax);
                        }
                    }
                    else if (radioButtonBalancedMarket.Checked)
                    {
                        if (amountTransfer > moneyMarketAmount)
                        {
                            Comunicats.WarringErrorSupply();
                        }
                        else
                        {
                            lock (thisLock)
                            {
                                tax = Decimal.Round(((decimal)amountTransfer * interestList[k][3].valueOfInterest * (decimal)0.02), 2);
                                transferValue = (decimal)amountTransfer * interestList[k][3].valueOfInterest - tax;
                                valueWalletUser -= transferValue; moneyMarketAmount -= amountTransfer;
                            }
                            AddStringListBox.SellingAddStringToListBox(interestList[k][3].nameOfInterst, listBoxInterest, transferValue, valueWalletUser, tax);
                        }
                    }
                }

            } // koniec warunku "czy jest INTem"; jeśli nie to jest wykonywana instrukcja poniższa 
            else
            {
                Comunicats.WarringCantDoIt();
            }

        }
        #endregion
        #region Funkcja prowadząca notowania, aż do wyłączenia programu.
        private void InterestContinue(int j)
        {//dekrementacja nie sprawdza sie przy czyszczeniu dataGridView
            dataGridViewInterest.Rows.RemoveAt(3);
            dataGridViewInterest.Rows.RemoveAt(2);
            dataGridViewInterest.Rows.RemoveAt(1);
            dataGridViewInterest.Rows.RemoveAt(0);
            interestOnePosition = new Interest[4];
            interestOnePosition[0] = new Interest(-90, 120, "Akcje", interestList[j - 1][0].valueOfInterest);
            interestOnePosition[1] = new Interest(-10, 50, "Obligacje", interestList[j - 1][1].valueOfInterest);
            interestOnePosition[2] = new Interest(-5, 20, "Rynek pieniężny", interestList[j - 1][2].valueOfInterest);
            interestOnePosition[3] = new Interest(-3, 70, "Rynek zrównoważony", interestList[j - 1][3].valueOfInterest);
            interestList.Add(interestOnePosition);
            dataGridViewInterest.Rows.Add(interestList[j][0].nameOfInterst, interestList[j][0].valueOfInterest, interestList[j][0].percentOfInterest * 100 + "%", DateTime.Now);
            dataGridViewInterest.Rows.Add(interestList[j][1].nameOfInterst, interestList[j][1].valueOfInterest, interestList[j][1].percentOfInterest * 100 + "%", DateTime.Now);
            dataGridViewInterest.Rows.Add(interestList[j][2].nameOfInterst, interestList[j][2].valueOfInterest, interestList[j][2].percentOfInterest * 100 + "%", DateTime.Now);
            dataGridViewInterest.Rows.Add(interestList[j][3].nameOfInterst, interestList[j][3].valueOfInterest, interestList[j][3].percentOfInterest * 100 + "%", DateTime.Now);
        }
        #endregion
        #region Funkcja kupująca, sprawdzenie warunków i diagramu możliwości.
        public void Buying()
        {
            int outValue = 1;
            bool ifInt = Int32.TryParse(textBoxHow.Text, out outValue);//Czy INT
            Object thisLock = new Object();//-> opis dalej
             if (ifInt == true)// nie można kupić części akcji tylko całkowite
             {
                 int amountTransfer = Convert.ToInt32(textBoxHow.Text);
                 if (amountTransfer == 0)
                 {//Nie można kupić zero akcji.
                     Comunicats.WarringCantDoIt();
                 }
                 else
                 {
                     if (radioButtonAction.Checked)
                     {
                             if (((decimal)amountTransfer * interestList[k][0].valueOfInterest) > valueWalletUser)
                             {
                                 Comunicats.WarringErrorSaldo();
                             }
                             else
                             {
                                 lock (thisLock)
                                 {
                                     transferValue = (decimal)amountTransfer * interestList[k][0].valueOfInterest;
                                     valueWalletUser -= transferValue;
                                     actionAmount += amountTransfer;
                                 }
                                 AddStringListBox.BuyingAddStringToListBox(interestList[k][0].nameOfInterst, listBoxInterest, transferValue, valueWalletUser, tax);
                             }
                     }
                     else if (radioButtonDebentures.Checked)
                     {
                             if (((decimal)amountTransfer * interestList[k][1].valueOfInterest) > valueWalletUser)
                             {
                                 Comunicats.WarringErrorSaldo();
                             }
                             else
                             {
                                 lock (thisLock)
                                 {
                                     transferValue = (decimal)amountTransfer * interestList[k][1].valueOfInterest;
                                     valueWalletUser -= transferValue;
                                     debenturesAmount += amountTransfer;
                                 }
                                 AddStringListBox.BuyingAddStringToListBox(interestList[k][1].nameOfInterst, listBoxInterest, transferValue, valueWalletUser, tax);
                             }
                     }
                     else if (radioButtonMoneyMarket.Checked)
                     {
                                if (((decimal)amountTransfer * interestList[k][2].valueOfInterest) > valueWalletUser)
                                {
                                    Comunicats.WarringErrorSaldo();
                                }
                                else
                                {
                                    lock (thisLock)
                                    {
                                        transferValue = (decimal)amountTransfer * interestList[k][2].valueOfInterest;
                                        valueWalletUser -= transferValue;
                                        balancedMarketAmount += amountTransfer;
                                    }
                                    AddStringListBox.BuyingAddStringToListBox(interestList[k][2].nameOfInterst, listBoxInterest, transferValue, valueWalletUser, tax);
                                }
                     }
                     else if (radioButtonBalancedMarket.Checked)
                     {
                                 if (((decimal)amountTransfer * interestList[k][3].valueOfInterest) > valueWalletUser)
                                 {
                                     Comunicats.WarringErrorSaldo();
                                 }
                                 else
                                 {
                                     lock (thisLock)
                                     {
                                         transferValue = (decimal)amountTransfer * interestList[k][3].valueOfInterest;
                                         valueWalletUser -= transferValue;
                                         moneyMarketAmount += amountTransfer;
                                     }
                                     AddStringListBox.BuyingAddStringToListBox(interestList[k][3].nameOfInterst, listBoxInterest, transferValue, valueWalletUser, tax);
                                 }
                     }
                 }
             }
             else
             {
                 Comunicats.WarringCantDoIt();
             }
        }
        #endregion
        #region Wywołanie okna do kradzieży.
        private void buttonUserListView_Click(object sender, EventArgs e)
        {
            Comunicats.ThieftDialog();
            FormUserList formUserList = new FormUserList(this);
            formUserList.ShowDialog();
            thieftCounter++;
            labelThieftCounter.Text = thieftCounter.ToString();
        }
        #endregion 
        #region Wywołanie zapisania notowań do pliku PDF.
        private void zapiszDoPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToFileSave.PdfSave(interestList);
        }
        #endregion
        #region Wywołanie zapisania stanu portfela do pliku XML.
        private void zapiszStanPorfelaDoXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToFileSave.XmlSave(valueWalletUser);
        }
        #endregion // taki przykład zapisu
        #region Zdarzenie - wybór z menu "Info o autorze".
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comunicats.ShowWalletCondition();
        }
        #endregion
        #region Zwiększanie progressBara
        private void timerProgress_Tick(object sender, EventArgs e)
        {
                progressBarInterest.Increment(1);
        }
        #endregion
        #region wylogowanie
        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Wyjście z aplikacji.
        private void wyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
        #endregion
        #region Zdarzenie - wybór z menu "Wyświetl stan portfela".
        private void wyświetlStanPortfelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comunicats.ShowWalletCondition(username, valueWalletUser, actionAmount, debenturesAmount, balancedMarketAmount, moneyMarketAmount);
        }
        #endregion   
    }
}
