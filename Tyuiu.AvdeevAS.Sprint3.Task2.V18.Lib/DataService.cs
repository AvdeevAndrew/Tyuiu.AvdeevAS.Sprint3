using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AvdeevAS.Sprint3.Task2.V18.Lib
{
    public class DataService : ISprint3Task2V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double product = 1; // Начальное значение произведения
            int k = startValue;

            do
            {
                product *= Math.Cos(value) + Math.Pow((double)k / 8, 3);
                k++;
            } while (k <= stopValue);

            return Math.Round(product, 3);
        }
    }

   
}
