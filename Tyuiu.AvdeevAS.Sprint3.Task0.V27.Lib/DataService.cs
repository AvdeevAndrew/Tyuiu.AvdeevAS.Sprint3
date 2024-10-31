using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AvdeevAS.Sprint3.Task0.V27.Lib
{
    public class DataService : ISprint3Task0V0
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sum = 0;
            for (int k = startValue; k <= stopValue; k++)
            {
                sum += Math.Pow(4.0 / Math.Pow(k, value), 2);
            }
            return sum;
        }
    }
}
