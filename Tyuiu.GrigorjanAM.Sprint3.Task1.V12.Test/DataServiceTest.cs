using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint3.Task1.V12.Lib;

namespace Tyuiu.GrigorjanAM.Sprint3.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 5;
            int k1 = 1;
            int k2 = 10;
            double res = ds.GetSumSeries(value, k1, k2);
            double wait = 1.001;
            Assert.AreEqual(wait, res);

        }
    }
}
