using Tyuiu.AvdeevAS.Sprint3.Task4.V6.Lib;
namespace Tyuiu.AvdeevAS.Sprint3.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            Assert.AreEqual(-34.855, ds.Calculate(-5,5));
        }
    }
}