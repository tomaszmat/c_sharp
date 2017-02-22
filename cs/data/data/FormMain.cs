using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

$cd /path/to/my/repo
$git remote add origin https://TomaszMatusiakKredek@bitbucket.org/TomaszMatusiakKredek/lab2pd.git
$git push -u origin --all # pushes up the repo and its refs for the first time
$git push -u origin --tags # pushes up any tags

namespace TomaszMatusiakLab02_06052015
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            dataGridViewArrivals.Rows.Add(textBoxRegisterNumber.Text,textBoxSupply.Text, textBoxAmount.Text);
            //wywolanie funkcji dodajace nowy wiersz w tabeli
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            Controler.FormMainController.SaveToFile(dataGridViewArrivals);
            //wywolanie funkcji statycznej SaveToFile
        }

        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            Controler.FormMainController.ReadFile(dataGridViewArrivals);
            //wywolanie funkcji statycznej ReadFile
        }

 

        private void buttonAutoReg_Click(object sender, EventArgs e)
        {
            //okno rejestrujące przyjazd ustawionego samochodu co sekunde (1000ms timer)
            FormAutoReg formAutoReg = new FormAutoReg();
            formAutoReg.Show();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            //okno informacyjne
            FormInfo formInfo = new FormInfo();
            formInfo.Show();
        }

        private void buttonCleandGridView_Click(object sender, EventArgs e)
        {
            //czyszczenie tabeli
            dataGridViewArrivals.Rows.Clear(); 
        }

        private void textBoxSearcher_TextChanged(object sender, EventArgs e)
        {
            //DataBase dt = new DataBase();
            // dt = (dataGridViewArrivals.DataSource).fill();
            // dataGridViewArrivals.RowCount Zwraca lub ustawia liczbę wierszy wyświetlanych w DataGridView - źródło MSDN
            if (radioButtonSortRegNum.Checked)
            {
                for (int i = 0; i < dataGridViewArrivals.RowCount; i++)
                {
                    if (textBoxSearcher.Text == dataGridViewArrivals.Rows[i].Cells[1].Value)
                        MessageBox.Show("istnieje");
                        //tutaj zamiast messageboxa powinno być cos w stylu aby indeks wiersza na pierwsza pozycje
                    else
                    {
                    }
                }
            } 
                /* tutaj probuje porównać z zawartościa, wersja jaskiniowa
                wszystkie opisy internetowe typu YT lub fora odnosza sie do filtorwania
                 z typowymi database lub z serwerami SQL;
                 */
            else if (radioButtonSortSuppluy.Checked)
            {
                for (int i = 0; i < dataGridViewArrivals.RowCount; i++)
                {
                    if (textBoxSearcher.Text == dataGridViewArrivals.Rows[2].Cells[i].Value)
                        MessageBox.Show("istnieje");
                    else
                    {
                    }
                }

            }
        }

        

          
    }
}
