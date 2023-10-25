using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MargaryanSG.Sprint3.Task5.V17.Lib;

namespace Tyuiu.MargaryanSG.Sprint3.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();


            int startValue1 = 1; int stopValue1 = 3; int startValue2 = 1; int stopValue2 = 12; int x = 2;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2); ;
            double wait = 143.624;

            Assert.AreEqual(res, wait);
        }
    }
}
