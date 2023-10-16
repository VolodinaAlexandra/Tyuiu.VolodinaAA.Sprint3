using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VolodinaAA.Sprint3.Task0.V27.Lib
{
    public class DataService : ISprint3Task0V27
    {
        public double GetSumSeries(double value)
        {
            double S = 0;
            for (int k = 1; k < 14; k++)
            {
                double num = Math.Round(Math.Pow((4 / Math.Pow(k, value)), 2),3);
                S += num;
            }
            return S;
        }
        
    }
}
