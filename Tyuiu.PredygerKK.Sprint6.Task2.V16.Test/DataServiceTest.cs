using Tyuiu.PredygerKK.Sprint6.Task2.V16.Lib;

namespace Tyuiu.PredygerKK.Sprint6.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] TempArray;
            TempArray = new double[len];

            TempArray[0] = -36.41;
            TempArray[1] = -22.07;
            TempArray[2] = 5.68;
            TempArray[3] = 16.72;
            TempArray[4] = 8.35;
            TempArray[5] = -0.5;
            TempArray[6] = 9.63;
            TempArray[7] = 16.29;
            TempArray[8] = 5.01;
            TempArray[9] = -22.4;
            TempArray[10] = -36.3;

            CollectionAssert.AreEqual(TempArray, ds.GetMassFunction(startValue, stopValue));
        }
    }
}