using Tyuiu.PredygerKK.Sprint6.Task7.V8.Lib;

namespace Tyuiu.PredygerKK.Sprint6.Task7.V8.Lib.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            string path = Path.Combine();
            int[,] expect_matrix = { };

            CollectionAssert.AreEqual(expect_matrix, ds.GetMatrix(path));
        }
    }
}