using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MedvederovaAB.Sprint3.Task5.V16.Lib
{
    public class DataService : ISprint3Task5V16
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumseries = 0;
            int j, k;
            for (j = startValue1; j <= stopValue1; j++)
            {
                for (k = startValue2; k <= stopValue2; k++)
                {
                    sumseries = sumseries + (Math.Cos(k) + Math.Pow(x, 2));
                }
            }
            return Math.Round(sumseries, 3);
        }
    }
}
