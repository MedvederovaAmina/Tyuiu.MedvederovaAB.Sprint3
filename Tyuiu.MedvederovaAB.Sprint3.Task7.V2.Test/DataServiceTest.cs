using Tyuiu.MedvederovaAB.Sprint3.Task7.V2.Lib;

namespace Tyuiu.MedvederovaAB.Sprint3.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startvalue = -5;
            int stopvalue = 5;
            int len = stopvalue - startvalue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = 59.49;
            valueWaitArray[1] = 38.47;
            valueWaitArray[2] = -2.81;
            valueWaitArray[3] = -19.67;
            valueWaitArray[4] = -8.42;
            valueWaitArray[5] = 0.57;
            valueWaitArray[6] = -6.30;
            valueWaitArray[7] = -20.14;
            valueWaitArray[8] = -3.51;
            valueWaitArray[9] = 38.13;
            valueWaitArray[10] = 59.60;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startvalue, stopvalue);
            CollectionAssert.AreEqual(valueWaitArray, res);

        }
    }
}