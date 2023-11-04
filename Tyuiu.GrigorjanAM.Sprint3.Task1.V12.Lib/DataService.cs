using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GrigorjanAM.Sprint3.Task1.V12.Lib
{
    public class DataService : ISprint3Task1V12
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i = 1;
            while (i <= 10)
            {
                sumSeries += Math.Pow((1 / Math.Pow(i, value)), 2);
                i++;
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
