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
            int startValue = 1;
            int stopValue = 9;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = -15.642;
            Assert.AreEqual(res, wait);
        }
    }
}
