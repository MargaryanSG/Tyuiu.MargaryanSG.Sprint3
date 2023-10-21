using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MargaryanSG.Sprint3.Task1.V24.Lib;

namespace Tyuiu.MargaryanSG.Sprint3.Task1.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 12;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* value = 5, startValue = 1, stopValue = 12                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double q = ds.GetSumSeries(value, startValue, stopValue);

            Console.WriteLine(q);
            Console.ReadKey();


        }
    }
}
