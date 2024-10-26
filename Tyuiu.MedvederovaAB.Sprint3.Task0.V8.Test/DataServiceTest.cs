using Tyuiu.MedvederovaAB.Sprint3.Task0.V8.Lib;

namespace Tyuiu.MedvederovaAB.Sprint3.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startvalue = 1;
            int stopvalue = 10;


            double res = ds.GetMultiplySeries(value, startvalue, stopvalue);


            double wait = 0.019;
            Assert.AreEqual(wait, res);
        }
    }
}