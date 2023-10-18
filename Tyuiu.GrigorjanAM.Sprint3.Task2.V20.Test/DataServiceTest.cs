using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint3.Task2.V20.Lib;

namespace Tyuiu.GrigorjanAM.Sprint3.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int k1 = 1;
            int k2 = 6;
            int x = 1;
            double res = ds.GetMultiplySeries(x, k1, k2);
            double wait = 914700.940;
            Assert.AreEqual(res, wait);
        }
    }
}
