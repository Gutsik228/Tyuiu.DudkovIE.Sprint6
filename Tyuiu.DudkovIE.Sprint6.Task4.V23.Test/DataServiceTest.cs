using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DudkovIE.Sprint6.Task4.V23.Lib;
namespace Tyuiu.DudkovIE.Sprint6.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = (stopValue - startValue) + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = -9;
            valueWaitArray[1] = -10;
            valueWaitArray[2] = -8;
            valueWaitArray[3] = -3;
            valueWaitArray[4] = 1;
            valueWaitArray[5] = 7;
            valueWaitArray[6] = 15;
            valueWaitArray[7] = 17;
            valueWaitArray[8] = 14;
            valueWaitArray[9] = 9;
            valueWaitArray[10] = 7;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
