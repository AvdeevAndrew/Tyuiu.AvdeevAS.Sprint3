using Tyuiu.AvdeevAS.Sprint3.Task1.V3.Lib;
namespace Tyuiu.AvdeevAS.Sprint3.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(10, ds.GetMultiplySeries(1,10));
        }
    }
}