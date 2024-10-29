using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MedvederovaAB.Sprint3.Task6.V30.Lib
{
    public class DataService : ISprint3Task6V30
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int count1 = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        count1++;
                    }
                }
            }
            return count1;
        }
    }
}
