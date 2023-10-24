using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MargaryanSG.Sprint3.Task4.V2.Lib
{
    public class DataService : ISprint3Task4V2
    {
        public double Calculate(int startValue, int stopValue)
        {
            int x;
            double y = 0;
            
            for (x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                y = y + (Math.Cos(x)/x);
                
            }
            return Math.Round(y, 3);
        }

     
    }
}
