using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AvdeevAS.Sprint3.Task1.V3.Lib
{
    public class DataService : ISprint3Task1V3
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double product = 1; // Начальное значение произведения
            int k = startValue;

            while (k <= stopValue)
            {
                product *= Math.Pow(k / (Math.Cos(5) + 1), 2);
                k++;
            }

            return Math.Round(product,3);
        }
    }
}
