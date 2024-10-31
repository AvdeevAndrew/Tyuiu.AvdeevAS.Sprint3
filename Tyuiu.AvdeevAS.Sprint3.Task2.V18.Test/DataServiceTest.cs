using Tyuiu.AvdeevAS.Sprint3.Task2.V18.Lib;
namespace Tyuiu.AvdeevAS.Sprint3.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.119, ds.GetMultiplySeries(1,1,4));
        }
    }
}