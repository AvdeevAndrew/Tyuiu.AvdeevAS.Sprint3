using Tyuiu.AvdeevAS.Sprint3.Task5.V17.Lib;
namespace Tyuiu.AvdeevAS.Sprint3.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.624 , ds.GetSumSumSeries(1, 1, 1, 3, 12));
        }
    }
}