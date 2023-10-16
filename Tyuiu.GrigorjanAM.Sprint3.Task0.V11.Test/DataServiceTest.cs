﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint3.Task0.V11.Lib;

namespace Tyuiu.GrigorjanAM.Sprint3.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 5;
            int k1 = 1;
            int k2 = 10;
            double res = ds.GetSumSeries(value, k1, k2);
            double wait = 0.042;
            Assert.AreEqual(wait, res);

        }
    }
}
