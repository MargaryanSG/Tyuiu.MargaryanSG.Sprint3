using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MargaryanSG.Sprint3.Task1.V24.Lib
{
    public class DataService : ISprint3Task1V24
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double q = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                q += (Math.Pow((2/(6 + Math.Pow(value, i))), i));
            }
            return Math.Round(q, 3);
        }
    }
}
