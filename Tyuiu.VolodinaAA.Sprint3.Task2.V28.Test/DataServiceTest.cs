using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint3.Task2.V28.Lib;


namespace Tyuiu.VolodinaAA.Sprint3.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSeriesValid()
        {
            DataService ds = new DataService();
            double value = 10;
            double p = ds.GetSumSeries(value);
            double wait = -15.642;
            Assert.AreEqual(p, wait);
        }
    }
}
