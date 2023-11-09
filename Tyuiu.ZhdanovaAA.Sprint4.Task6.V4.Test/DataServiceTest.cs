using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint4.Task6.V4.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint4.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            var city = new string[] { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Самара" };
            string[] res = ds.Calculate(city);
            string[] wait = { "Москва", "Самара" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
