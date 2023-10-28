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
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double P = 1;
            do
            {
                P = P * (Math.Pow(2, startValue) / (startValue + 1)) * Math.Cos(1.8);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(P, 3);
        }
    }
}
