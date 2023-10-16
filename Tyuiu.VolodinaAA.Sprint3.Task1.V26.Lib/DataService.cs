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
        public double GetMultiplySeries()
        {
            double S = 0;
            int k = 1;
            while (k < 9)
            {
                double num = Math.Round(Math.Pow(6 / Math.Pow(5, k), 2),3);
                S += num;
                k++;
            }
            return S;
        }
    }
}
