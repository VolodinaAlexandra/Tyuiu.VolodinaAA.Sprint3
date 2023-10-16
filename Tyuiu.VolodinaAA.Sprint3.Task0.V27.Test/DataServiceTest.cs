﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint3.Task0.V27.Lib;

namespace Tyuiu.VolodinaAA.Sprint3.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSeriesValid()
        {
            DataService ds = new DataService();
            double value = 5;
            double S = ds.GetSumSeries(value);
            double wait = 16.016;
            Assert.AreEqual(S, wait);
        }
    }
}
