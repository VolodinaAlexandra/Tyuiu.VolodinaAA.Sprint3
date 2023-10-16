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
            int startValue = 1;
            int stopValue = 8;
            double S = ds.GetMultiplySeries(startValue,stopValue);
            double wait = 1.5;
            Assert.AreEqual(S, wait);
        }
    }
}
