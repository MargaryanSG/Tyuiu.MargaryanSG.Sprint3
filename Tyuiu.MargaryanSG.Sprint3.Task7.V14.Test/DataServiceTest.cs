using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MargaryanSG.Sprint3.Task7.V14.Lib;

namespace Tyuiu.MargaryanSG.Sprint3.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5; int stopValue = 5;

            int len = (stopValue - startValue) + 1;
            double[] wait;
            wait = new double[len];

            wait[0] = -19.62;
            wait[1] = -17.12;
            wait[2] = -18.15;
            wait[3] = -63.13;
            wait[4] = -24.92;
            wait[5] = -5.00;
            wait[6] = -1.46;
            wait[7] = 1.57;
            wait[8] = 6.38;
            wait[9] = 32.78;
            wait[10] = 225.11;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
