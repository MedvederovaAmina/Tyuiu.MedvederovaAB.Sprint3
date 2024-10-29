using Tyuiu.MedvederovaAB.Sprint3.Task4.V5.Lib;

namespace Tyuiu.MedvederovaAB.Sprint3.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startvalue = -5;
            int stopvalue = 5;

            double res = ds.Calculate(startvalue, stopvalue);
            double wait = -0.858;
            Assert.AreEqual(wait, res);
        }
    }
}