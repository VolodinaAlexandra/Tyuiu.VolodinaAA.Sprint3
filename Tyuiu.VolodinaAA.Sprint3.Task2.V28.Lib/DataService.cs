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
        public double GetSumSeries(double value)
        {
            double p = 1;
            int k = 1;
            do
            {
                value = (Math.Pow(2, k) / (k + 1)) * Math.Cos(1.8);
                p *= value;
                k++;
            }
            while (k < 10);
            return Math.Round(p,3);
        }
    }
}
