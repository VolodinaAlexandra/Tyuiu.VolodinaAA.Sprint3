﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolodinaAA.Sprint3.Task3.V17.Lib;

namespace Tyuiu.VolodinaAA.Sprint3.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ConvertStringToIntValid()
        {
            DataService ds = new DataService();
            string value = "*vn98n! b,";
            string res = "98";
            int num = ds.ConvertStringToInt(value);
            int wait = 98;
            Assert.AreEqual(num, wait);
        }
    }
}
