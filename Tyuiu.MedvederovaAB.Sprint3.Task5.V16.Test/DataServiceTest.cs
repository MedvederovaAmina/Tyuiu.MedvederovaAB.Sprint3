using Tyuiu.MedvederovaAB.Sprint3.Task5.V16.Lib;

namespace Tyuiu.MedvederovaAB.Sprint3.Task5.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            int startvalue1 = 1;
            int stopvalue1 = 3;
            int startvalue2 = 1;
            int stopvalue2 = 10;
            double res = ds.GetSumSumSeries(x, startvalue1, stopvalue1, startvalue2, stopvalue2);
            double wait = 30.458;
            Assert.AreEqual(wait, res);
        }
    }
}