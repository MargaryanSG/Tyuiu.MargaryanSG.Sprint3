using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MargaryanSG.Sprint3.Task7.V14.Lib;

namespace Tyuiu.MargaryanSG.Sprint3.Task7.V14
{
    class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5; int stopValue = 5;

            Console.WriteLine("Старт шага " + startValue);
            Console.WriteLine("Конец шага " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] z;
            z = new double[len];

            z = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+------------+");
            Console.WriteLine("|    X     |    f(x)    |");
            Console.WriteLine("+----------+------------+");
            for (int t = 0; t <= len - 1; t++)
            {
                Console.WriteLine("|{0, 5:d}     |  {1, 7:f2}   |", startValue, z[t]);
                startValue++;
            }
            Console.WriteLine("+----------+------------+");
            Console.ReadKey();


        }
    }
}
