using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MargaryanSG.Sprint3.Task3.V14.Lib;

namespace Tyuiu.MargaryanSG.Sprint3.Task3.V14
{
    class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            string value = "dgt ghedd bed"; char replaceable = 'd'; char replacement = '’';

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* value = 0.25, startValue = 1, stopValue = 8                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string q = ds.ReplaceCharInString(value, replaceable, replacement);

            Console.WriteLine(q);
            Console.ReadKey();


        }
    }
}
