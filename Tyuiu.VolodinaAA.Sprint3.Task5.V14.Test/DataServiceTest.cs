﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint3.Task5.V14.Lib;

namespace Tyuiu.VolodinaAA.Sprint3.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumSumSeriesValid()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 14;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = -31.275;
            Assert.AreEqual(wait, res);
        }
    }
}
