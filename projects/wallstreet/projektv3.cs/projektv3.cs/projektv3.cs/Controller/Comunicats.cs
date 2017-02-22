using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormHello.cs.Controller
{
    public static class Comunicats
    {
        public static void WarringCantDoIt()
        {// Pokazuje komunikat, gdy np. użytkownik wpisze w pole ilośći wartość inną niż liczba całkowita.
            string header = "Ostrzeżenie";
            string comunicatText = "Operacja niedozwolona!";
            MessageBox.Show(comunicatText, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void WarringErrorSaldo()
        {// Pokazuje komunikat, gdy użytkownik chce kupić np. akcje, a nie posiada do tego środków.
            string header = "Ostrzeżenie";
            string comunicatText = "Brak środków na koncie!";
            MessageBox.Show(comunicatText, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void WarringErrorSupply()
        {// Pokazuje komunikat, gdy użytkownik chce np. sprzedać akcje, a nie posiada tylu.
            string header = "Ostrzeżenie";
            string comunicatText = "Brak podstaw do wykonania operacji!";
            MessageBox.Show(comunicatText, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void WarringNothingWrite()
        {
            string header = "Ostrzeżenie";
            string comunicatText = "Nic nie wpisałeś!!";
            MessageBox.Show(comunicatText, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void WrongPassOrLog()
        {
            string header = "Błąd";
            string comunicatText = "Zły login lub hasło!!";
            MessageBox.Show(comunicatText, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void TooShortPass()
        {
            string header = "Ostrzeżenie";
            string comunicatText = "Zbyt krotkie hasło!!";
            MessageBox.Show(comunicatText, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void FailureText()
        {
            string header = "Ostrzeżenie";
            string comunicatText = "Uzupełnij puste pole!";
            MessageBox.Show(comunicatText, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void TooMuchThieft()
        {
            string header = "Przykro mi!";
            string comunicatText = "Złapała Cie policja!\n Musisz przystopować.\n Za chwilę nastąpi wylogowanie.";
            MessageBox.Show(comunicatText, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ThieftDialog()
        {
            string header = "Pamietaj, że.....!";
            string comunicatText = "Otwarcie tego okna, wiąże się z przykuciem uwagi organów śledczych";
            MessageBox.Show(comunicatText, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void GenerateXML()
        {
            string header = "Udało się";
            string comunicatText = "Wygenerowano plik XML z portfelem :\n D:\\portfel.xml";
            MessageBox.Show(comunicatText, header, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        public static void ShowWalletCondition()
        {
            string header = "Autor";
            string comunicatText = "\tTomasz Matusiak\n \tmatusiaktomasz@windowslive.com";
            MessageBox.Show(comunicatText, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowWalletCondition(string username, decimal valueWalletUser, int actionAmount, int debenturesAmount, int balancedMarketAmount, int moneyMarketAmount)
        {
            string header = "Użytkownik: " + username;
            string comunicatText = "Stan konta: " + valueWalletUser + "\nIlość akcji: " + actionAmount + "\n" + "Ilość obligacji: " + debenturesAmount + "\n" + "Ilość WZ: " + balancedMarketAmount + "\n" + "Ilość WP: " + moneyMarketAmount + "\n";
            MessageBox.Show(comunicatText, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void GeneratePDF()
        {
            string header = "Udało się" ;
            string comunicatText = "Wygenerowano plik PDF z notowaniami :\n D:\\Notowania.pdf";
            MessageBox.Show(comunicatText, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #region Komunikat po udaje rejestracji.
        public static void RegisterHello(string username)
        {
            string header = "Witaj użytkowniku: " + username+ "  !";
            string comunicatText = "Gratuluje!\nZostałeś nowym użytkownikiem naszej platformy!";
            MessageBox.Show(comunicatText, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #region Komunikat informujący, że dany użytkownik już istnieje
        public static void UserExist()
        {
            string header = "Przyrko mi, ale..";
            string comunicatText = "Istnieje już użytkownik o takiej nazwie!\nWybierz inną!";
            MessageBox.Show(comunicatText, header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
#endregion
        #region Komunikat powitalny.
        public static void LogHello(string username)
        {
            string header = "Witaj: " + username + "  !";
            string comunicatText = "Aby fortuna Ci dziś sprzyjała!";
            MessageBox.Show(comunicatText, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
