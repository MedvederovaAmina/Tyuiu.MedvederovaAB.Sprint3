using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MedvederovaAB.Sprint3.Task0.V8.Lib
{
    public class DataService : ISprint3Task0V8
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double ProductSeries = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {

                ProductSeries = ProductSeries * ((Math.Pow(value, i) + 1) * Math.Cos(4));

            }
            return Math.Round(ProductSeries, 3);
        }

    }
}
