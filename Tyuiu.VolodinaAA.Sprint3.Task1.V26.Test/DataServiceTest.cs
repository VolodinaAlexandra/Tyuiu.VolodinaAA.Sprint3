using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint3.Task1.V26.Lib;

namespace Tyuiu.VolodinaAA.Sprint3.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeriesValid()
        {
            DataService ds = new DataService();
            double S = ds.GetMultiplySeries();
            double wait = 1.5;
            Assert.AreEqual(S, wait);
        }
    }
}
