using Tyuiu.AvdeevAS.Sprint3.Task6.V17.Lib;
namespace Tyuiu.AvdeevAS.Sprint3.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(43, ds.GetSumTheDivisors(10,20));
        }
    }
}