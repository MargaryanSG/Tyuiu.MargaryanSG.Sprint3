using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MargaryanSG.Sprint3.Task2.V24.Lib
{
    public class DataService : ISprint3Task2V24
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double q = 1;

            int k = startValue;

            do
            {
                q *= ((Math.Pow(value, k) + 4) * Math.Cos(value));
                k++;
            }
            while (k <= stopValue);
            return Math.Round(q, 3);
        }
    }
}
