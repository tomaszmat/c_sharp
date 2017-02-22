using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace TomaszMatusiakLab02_06052015.Controler
{
   public static class FormMainController
    {
        public static void SaveToFile(DataGridView dataGridViewArrivals)
        {
            //funkcja zajmująca się zapisywaniem do pliku
            StreamWriter stream = new StreamWriter("test.txt");
            for (int i = 0; i < dataGridViewArrivals.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewArrivals.ColumnCount; j++)
                {
                    stream.WriteLine(dataGridViewArrivals.Rows[i].Cells[j].Value + ";");

                }
               
            }
            stream.Close();
        }

        public static void ReadFile(DataGridView dataGridViewArrivals)
        {
            //funkcja zajmująca się odczytywanie ciągów wyrazowych z pliku
            StreamReader streamReadHelper = new StreamReader("test.txt");
            char[] charsToTrim = { ';' };
            string semicolon = streamReadHelper.ReadToEnd();
            int a = (semicolon.Split(';').Length/3);
            StreamReader streamRead = new StreamReader("test.txt");
            for (int i = 0; i < a; i++)
            {
                string registerNumber = (streamRead.ReadLine()).TrimEnd(charsToTrim);
                string supply = (streamRead.ReadLine()).TrimEnd(charsToTrim);;
                string amount = (streamRead.ReadLine()).TrimEnd(charsToTrim);;
                dataGridViewArrivals.Rows.Add(registerNumber, supply, amount);
            }
            streamReadHelper.Close();
            streamRead.Close();            

         }
    }

   
}
