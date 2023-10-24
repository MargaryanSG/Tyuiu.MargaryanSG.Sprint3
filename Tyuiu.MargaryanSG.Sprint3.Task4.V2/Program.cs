using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MargaryanSG.Sprint3.Task4.V2.Lib;

namespace Tyuiu.MargaryanSG.Sprint3.Task4.V2
{
    class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            int starnValue = -5; int stopValue = 5;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* value = 0.25, startValue = 1, stopValue = 8                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double y = ds.Calculate(starnValue, stopValue);

            Console.WriteLine(y);
            Console.ReadKey();


        }
    }
}
