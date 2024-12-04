using Tyuiu.PredygerKK.Sprint6.Task0.V17.Lib;

namespace Tyuiu.PredygerKK.Sprint6.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            int x = 3;
            double expect = 6.695;
            Assert.AreEqual(expect, ds.Calculate(x));
        }
    }
}