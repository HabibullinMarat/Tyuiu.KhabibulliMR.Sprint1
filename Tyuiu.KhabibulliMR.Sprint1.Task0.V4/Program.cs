using Tyuiu.KhabibullinMR.Sprint1.Task0.V4.Lib;

namespace Tyuiu.KhabibullinMR.Sprint1.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #1 | Выполнил: Хабибуллин М. Р. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                ");
            Console.WriteLine("* Тема : Базовые навыки работы в C#                                        ");
            Console.WriteLine("* Задание #0                                                               ");
            Console.WriteLine("* Вариант #4                                                               ");
            Console.WriteLine("* Выполнил : Хабибуллин Марат Рамильевич | ИИПб-24-2                       ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                                ");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 4/2*5/(3+2)*(5-2)        ");
            Console.WriteLine("* и печатает результат на экран.                                           ");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* 4/2*5/(3+2)*(5-2)                                                        ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                 ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.WriteLine();
        }
    }
}
