using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AvdeevAS.Sprint3.Task6.V17.Lib
{
    public class DataService : ISprint3Task6V17
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalDivisorsCount = 0;

            for (int num = startValue; num <= stopValue; num++)
            {
                int divisorsCount = 0;

                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        divisorsCount++;
                    }
                }

                totalDivisorsCount += divisorsCount;
            }

            return totalDivisorsCount;
        }
    }
}
