using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VolodinaAA.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double SumSeries = 1;
            do
            {
                SumSeries = SumSeries * (Math.Pow(2, startValue) / (startValue + 1)) * Math.Cos(value);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(SumSeries,3);
        }
    }
}
