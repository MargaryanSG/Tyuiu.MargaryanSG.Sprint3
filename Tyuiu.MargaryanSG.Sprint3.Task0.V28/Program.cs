﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MargaryanSG.Sprint3.Task0.V28.Lib;

namespace Tyuiu.MargaryanSG.Sprint3.Task0.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 17;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* value = 0.25, startValue = 1, stopValue = 17                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double q = ds.GetMultiplySeries(value, startValue, stopValue);

            Console.WriteLine(q);
            Console.ReadKey();


        }
    }
}
