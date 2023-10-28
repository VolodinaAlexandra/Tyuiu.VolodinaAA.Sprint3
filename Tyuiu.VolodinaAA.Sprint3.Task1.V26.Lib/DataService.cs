using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VolodinaAA.Sprint3.Task1.V26.Lib
{
    public class DataService : ISprint3Task1V26
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double S = 0;
            while (startValue <= stopValue)
            {
                S = S + Math.Pow(6 / Math.Pow(value, startValue), 2);
                startValue++;
            }
            return Math.Round(S, 3);
        }
    }
}
