﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AvdeevAS.Sprint3.Task4.V17.Lib
{
    public class DataService : ISprint3Task4V6
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) // Если x = 0, прерываем циклdfdf
                {
                    break;
                }

                double y = x / (Math.Cos(x) * Math.Sin(x));
                sum += y;
            }

            return Math.Round(sum,3);
        }
    }
}
