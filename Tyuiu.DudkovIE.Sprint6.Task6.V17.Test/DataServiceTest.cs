using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DudkovIE.Sprint6.Task6.V17.Lib;
namespace Tyuiu.DudkovIE.Sprint6.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.DudkovIE.Sprint6\Tyuiu.DudkovIE.Sprint6.Task6.V17\bin\Debug\InPutFileTask6V17.txt";
            string result = ds.CollectTextFromFile(path);
            string wait = "wFrlYaZtHI  XuLENkL BV ltxrhBXm  HbJcPW";

            Assert.AreEqual(wait, result);
        }
    }
}
