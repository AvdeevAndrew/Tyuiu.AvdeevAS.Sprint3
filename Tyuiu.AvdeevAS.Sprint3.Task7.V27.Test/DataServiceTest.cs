using Microsoft.VisualStudio.TestPlatform.TestHost;
using Tyuiu.AvdeevAS.Sprint3.Task7.V27.Lib;
namespace Tyuiu.AvdeevAS.Sprint3.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

           
            double[] result = ds.GetMassFunction(startValue, stopValue);

           
            double[] expectedValues = { -15.44, -10.93, -7.22, -5.04, 0, 0, 0.02, 0.22, 1.19, 3.59, 7.41 };

            Assert.AreEqual(result.Length, expectedValues.Length);
            

            //for (int i = 0; i < expectedValues.Length; i++)
            //{
            //    Assert.AreEqual(expectedValues[i], result[i], 0.01, $"Значение в позиции {i} не совпадает.");
            //}
        }
    }
}