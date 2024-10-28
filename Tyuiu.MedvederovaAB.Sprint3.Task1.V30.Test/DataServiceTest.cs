using Tyuiu.MedvederovaAB.Sprint3.Task1.V30.Lib;

namespace Tyuiu.MedvederovaAB.Sprint3.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.5;
            int startvalue = 1;
            int stopvalue = 12;
            double res = ds.GetSumSeries(value, startvalue, stopvalue);
            double wait = 1.959;
            Assert.AreEqual(wait, res);
        }
    }
}