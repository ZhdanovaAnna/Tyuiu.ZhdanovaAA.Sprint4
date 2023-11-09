using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint4.Task5.V15.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint4.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -6, -3, -5, -3, -6 },
                                          { -4, -6, 2, -5, -6 },
                                          { -2, -3, -3, 3, -5 },
                                          { -2, -6, -6, -6, -2 },
                                          { -6, -6, -4, -3, -6 } };

            int res = ds.Calculate(mas2);

            Assert.AreEqual(5, res);
        }
    }
}
