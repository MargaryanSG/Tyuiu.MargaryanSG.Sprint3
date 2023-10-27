using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MargaryanSG.Sprint3.Task6.V27.Lib;

namespace Tyuiu.MargaryanSG.Sprint3.Task6.V27
{
    class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();
            int startValue = 14; int stopValue = 20;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* startValue = 14, stopValue = 20                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int r = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine(r);
            Console.ReadKey();


        }
    }
}
