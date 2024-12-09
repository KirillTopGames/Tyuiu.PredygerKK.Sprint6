using Tyuiu.PredygerKK.Sprint6.Task6.V13.Lib;

namespace Tyuiu.PredygerKK.Sprint6.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();

            string path = Path.Combine("C:", "DataSprint6", "InPutDataFileTask6V13.txt");
            string expect_string = "WLCdQb ehWGn McJC lhTKeblSG dXbj";
            string actual_string = ds.CollectTextFromFile(path);

            Assert.AreEqual(expect_string, actual_string);
        }
    }
}