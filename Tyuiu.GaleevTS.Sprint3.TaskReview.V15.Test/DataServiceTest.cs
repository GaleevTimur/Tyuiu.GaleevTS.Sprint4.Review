using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GaleevTS.Sprint3.TaskReview.V15.Lib;

namespace Tyuiu.GaleevTS.Sprint3.TaskReview.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 4;
            int columns = 2;
            int[,] mtrx = new int[rows, columns];
            string str = "10293847";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
