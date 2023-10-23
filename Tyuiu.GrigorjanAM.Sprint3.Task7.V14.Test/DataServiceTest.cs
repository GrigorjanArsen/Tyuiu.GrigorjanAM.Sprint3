using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint3.Task7.V14.Lib;

namespace Tyuiu.GrigorjanAM.Sprint3.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startvalue = -2;
            int stopvalue = 2;
            int len = stopvalue - startvalue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -63.13;
            valueWaitArray[1] = -24.92;
            valueWaitArray[2] = -5.0;
            valueWaitArray[3] = -1.46;
            valueWaitArray[4] = 1.57;
            double[] res;
            res = ds.GetMassFunction(startvalue, stopvalue);
            CollectionAssert.AreEqual(res, valueWaitArray);

        }
    }
}
