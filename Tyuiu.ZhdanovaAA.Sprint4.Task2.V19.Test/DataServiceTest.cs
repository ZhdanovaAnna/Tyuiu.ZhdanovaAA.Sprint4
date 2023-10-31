using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint4.Task2.V19.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint4.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 4, 3, 2, 5, 0, 2 };
            int sumArray = ds.Calculate(numsArray);

            Assert.AreEqual(9, sumArray);
        }
    }
}
