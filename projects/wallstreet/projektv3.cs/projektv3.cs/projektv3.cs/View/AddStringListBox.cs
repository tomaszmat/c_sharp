using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormHello.cs.View
{
    public static class AddStringListBox
    {
        #region Dodawanie pozycji do listBoxa po udaje sprzedaży.
        public static void SellingAddStringToListBox(string name, ListBox listBoxInterest, decimal transferValue, decimal valueWalletUser, decimal tax)
        {
            listBoxInterest.Items.Add("Sprzedaż "+name+". Wartość transakcji z pobrana prowizją : " + transferValue);
            listBoxInterest.Items.Add("Stan konta po tej operacji wynosi: " + valueWalletUser);
            listBoxInterest.Items.Add("Prowizja: " + tax);
            listBoxInterest.Items.Add(Environment.NewLine);
        }
        #endregion
        #region Dodawanie pozycji do listBoxa po udanym zakupie.
        public static void BuyingAddStringToListBox(string name, ListBox listBoxInterest, decimal transferValue, decimal valueWalletUser, decimal tax)
        {
            listBoxInterest.Items.Add("Zakup: " + name + "  o wartości: " + transferValue);
            listBoxInterest.Items.Add("Stan konta po tej operacji wynosi: " + valueWalletUser);
            listBoxInterest.Items.Add(Environment.NewLine);
        }
        #endregion
    }
}
