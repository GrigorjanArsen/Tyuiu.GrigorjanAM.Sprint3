using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint3.Task4.V14.Lib;

namespace Tyuiu.GrigorjanAM.Sprint3.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int x = -5;
            int y = 5;
            double z = ds.Calculate(x, y);
            double wait = 6.263;
            Assert.AreEqual(wait, z);
        }
    }
}
