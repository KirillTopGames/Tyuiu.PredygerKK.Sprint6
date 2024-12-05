using Tyuiu.PredygerKK.Sprint6.Task1.V27.Lib;

namespace Tyuiu.PredygerKK.Sprint6.Task1.V27.Test
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

            TempArray[0] = 13.81;
            TempArray[1] = 11.87;
            TempArray[2] = 9.87;
            TempArray[3] = 7.74;
            TempArray[4] = 5.36;
            TempArray[5] = 2.5;
            TempArray[6] = 0;
            TempArray[7] = 0.79;
            TempArray[8] = -1.75;
            TempArray[9] = -3.78;
            TempArray[10] = -5.71;

            CollectionAssert.AreEqual(TempArray, ds.GetMassFunction(startValue, stopValue));
        }
    }
}