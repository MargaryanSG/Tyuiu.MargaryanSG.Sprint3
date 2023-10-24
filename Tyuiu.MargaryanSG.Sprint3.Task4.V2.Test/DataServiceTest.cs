using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MargaryanSG.Sprint3.Task4.V2.Lib;

namespace Tyuiu.MargaryanSG.Sprint3.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();


            int starnValue = -5; int stopValue = 5;

            double res = ds.Calculate(starnValue, stopValue);
            double wait = 0.104;

            Assert.AreEqual(res, wait);
        }
    }
}
