using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint3.Task5.V8.Lib;

namespace Tyuiu.GrigorjanAM.Sprint3.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSS()
        {

            DataService ds = new DataService();

            int x = 1;
            int x2 = 1;
            int y = 3;
            int y2 = 12;
            double res = ds.GetSumSumSeries(x, x2, y, y2);
            double wait = 119.066;
            Assert.AreEqual(wait, res);

        }
    }
}
