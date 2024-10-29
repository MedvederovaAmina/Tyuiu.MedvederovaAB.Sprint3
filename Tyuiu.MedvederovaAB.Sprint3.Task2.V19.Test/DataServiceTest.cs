using Tyuiu.MedvederovaAB.Sprint3.Task2.V19.Lib;

namespace Tyuiu.MedvederovaAB.Sprint3.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startvalue = 1;
            int stopvalue = 10;
            double res = ds.GetSumSeries(startvalue, stopvalue);
            double wait = -0.709;
            Assert.AreEqual(wait, res);
        }
    }
}