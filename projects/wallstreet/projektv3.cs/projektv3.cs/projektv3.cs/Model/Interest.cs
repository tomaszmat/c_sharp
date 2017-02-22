using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThreadsTimer
{
    public class Interest
    {
        #region Atrybuty klasy Interest
        public decimal percentOfInterest;
        private const decimal constToDiv = 10000; 
        public string nameOfInterst; 
        public decimal valueOfInterest;
        #endregion
        #region Konstruktor klasy Interest
        public Interest(int leftEnd, int rightEnd, string nameOfInterst, decimal value)
        {
            this.nameOfInterst = nameOfInterst;
            Random random = new Random();
            Random rnd = new Random();
            decimal minus = (decimal)rnd.Next(-1, 1);// dodatkowy minus
            if (minus == 0)
            {
                percentOfInterest = ((decimal)random.Next(leftEnd, rightEnd)) / constToDiv;
            }
            else
            {
                percentOfInterest = minus*((decimal)random.Next(leftEnd, rightEnd)) / constToDiv;
            }
            value = (value *  percentOfInterest) + value;
            valueOfInterest = Decimal.Round(value, 2); //zaokrąglanie-> format rzeczywisty x zł yy gr.
        }
        #endregion
    }
}
