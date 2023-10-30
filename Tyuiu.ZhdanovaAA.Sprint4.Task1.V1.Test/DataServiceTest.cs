using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint4.Task1.V1.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint4.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 8, 2, 7, 5, 0, 7, 4, 7, 5, 7 };
            int res = ds.Calculate(numsArray);

            Assert.AreEqual(14, res);
        }
    }
}
