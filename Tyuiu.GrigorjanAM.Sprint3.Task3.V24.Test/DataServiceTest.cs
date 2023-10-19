using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint3.Task3.V24.Lib;
namespace Tyuiu.GrigorjanAM.Sprint3.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckReplaceCharInString()
        {
            DataService ds = new DataService();

            string str = "gaaagagaga";
            char chr = 'g';
            char rhc = '*';
            string res = ds.ReplaceCharInString(str, chr, rhc);
            string wait = "*aaa*a*a*a";
            Assert.AreEqual(wait, res);
            
        }
    }
}
