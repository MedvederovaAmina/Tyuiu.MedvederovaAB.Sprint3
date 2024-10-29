using Tyuiu.MedvederovaAB.Sprint3.Task6.V30.Lib;

namespace Tyuiu.MedvederovaAB.Sprint3.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startvalue = 11;
            int stopvalue = 17;
            int res = ds.GetSumTheDivisors(startvalue, stopvalue);
            int wait = 25;
            Assert.AreEqual(wait, res);
        }
    }
}