using Microsoft.VisualStudio.TestPlatform.TestHost;
using Tyuiu.AvdeevAS.Sprint3.Task0.V27.Lib;

namespace Tyuiu.AvdeevAS.Sprint3.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 13;

            // Act
            double result = ds.GetSumSeries(value, startValue, stopValue);

            // Assert
            Assert.AreEqual(89230044518.925, result);
        }
    }
}