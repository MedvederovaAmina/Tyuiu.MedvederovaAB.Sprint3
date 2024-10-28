﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MedvederovaAB.Sprint3.Task1.V30.Lib
{
    public class DataService : ISprint3Task1V30
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 1;
            while (startValue <= stopValue)
            {
                sumSeries = sumSeries + (Math.Pow(value, startValue) + 5 / (startValue + 4)) * Math.Sin(value);
                startValue++;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}