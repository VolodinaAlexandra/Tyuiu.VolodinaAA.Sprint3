﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint3.Task6.V4.Lib;

namespace Tyuiu.VolodinaAA.Sprint3.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumTheDivisorsValid()
        {
            DataService ds = new DataService();
            int startValue = 14;
            int stopValue = 20;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 8;
            Assert.AreEqual(wait, res);
        }
    }
}
