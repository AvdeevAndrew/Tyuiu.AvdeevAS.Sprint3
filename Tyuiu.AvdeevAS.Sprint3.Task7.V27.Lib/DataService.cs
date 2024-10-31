using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AvdeevAS.Sprint3.Task7.V27.Lib
{
    public class DataService : ISprint3Task7V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] results = new double[length];

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx;

                // Проверка деления на ноль
                if (x == -1)
                {
                    fx = 0; // При делении на ноль возвращаем 0
                }
                else
                {
                    fx = (Math.Cos(x) / (x + 1)) - (Math.Cos(x) * 1.3) + (3 * x);
                }

                // Округление до двух знаков после запятой
                results[x - startValue] = Math.Round(fx, 2);
            }

            return results;
        }
    }
}
