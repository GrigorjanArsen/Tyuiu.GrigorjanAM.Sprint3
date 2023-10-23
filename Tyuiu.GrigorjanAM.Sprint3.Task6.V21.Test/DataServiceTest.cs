using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint3.Task6.V21.Lib;

namespace Tyuiu.GrigorjanAM.Sprint3.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startvalue = 1;
            int stopvalue = 5;
            int wait = 21;
            int res = ds.GetSumTheDivisors(startvalue, stopvalue);
            Assert.AreEqual(res, wait);

        }
    }

}   
