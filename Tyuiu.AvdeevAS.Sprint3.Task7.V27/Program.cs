using Tyuiu.AvdeevAS.Sprint3.Task7.V27.Lib;
namespace Tyuiu.AvdeevAS.Sprint3.Task7.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Авдеев А.С. | ИБКСБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  Спринт #3                              *");
            Console.WriteLine("* Тема: <...>                                                             *");
            Console.WriteLine("*                              Задание #5                                 *");
            Console.WriteLine("*                              Вариант #17                                *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("*      Написать программу, которая отвечает всем требованиям задания.     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");
            Console.WriteLine("***************************************************************************");


            
            int startValue = -5;
            int stopValue = 5;

            Program program = new Program();
            double[] results = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("Значения функции F(x):");
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"F({startValue + i}) = {results[i]}");
            }



            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetMassFunction(1,19));

            Console.ReadKey();

           
        }
    }
}
