using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MargaryanSG.Sprint3.Task5.V17.Lib;

namespace Tyuiu.MargaryanSG.Sprint3.Task5.V17
{
    class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            int startValue1 = 1; int stopValue1 = 3; int startValue2 = 1; int stopValue2 = 12; int x = 2;

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("* startValue1 = 1, stopValue1 = 3, startValue2 = 1, stopValue2 = 12, x = 2 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            double y = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine(y);
            Console.ReadKey();


        }
    }
}
