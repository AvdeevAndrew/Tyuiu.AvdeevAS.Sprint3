using Tyuiu.AvdeevAS.Sprint3.Task4.V17.Lib;
namespace Tyuiu.AvdeevAS.Sprint3.Task4.V17
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
            Console.WriteLine("*                              Задание #4                                 *");
            Console.WriteLine("*                              Вариант #6                                *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("*      Написать программу, которая отвечает всем требованиям задания.     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");
            Console.WriteLine("***************************************************************************");






            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(1,14));

            Console.ReadKey();
        }
    }
}
