using Tyuiu.PredygerKK.Sprint6.Task5.V12.Lib;

namespace Tyuiu.PredygerKK.Sprint6.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();

            string path = Path.Combine("C:", "DataSprint6", "InPutDataFileTask5V12.txt");
            double[] ExpectArray = new double[] { -13, -19, -9.82, 13, 11.49, -9.71, 3.36, 14.52, 16, 13.66, 0.48, 4.13, -0.11, 19, -17.36, 11, 11.28, -12, -12.35};

            CollectionAssert.AreEqual(ExpectArray, ds.LoadFromDataFile(path));
        }
    }
}