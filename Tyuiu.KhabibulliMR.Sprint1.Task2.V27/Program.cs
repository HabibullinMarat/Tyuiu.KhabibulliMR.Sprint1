using Tyuiu.KhabibulliMR.Sprint1.Task2.V27.Lib;

namespace Tyuiu.KhabibulliMR.Sprint1.Task2.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Хабибуллин М. Р. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                ");
            Console.WriteLine("* Тема : Ариметические операторы в C#                                      ");
            Console.WriteLine("* Задание #2                                                               ");
            Console.WriteLine("* Вариант #27                                                              ");
            Console.WriteLine("* Выполнил : Хабибуллин Марат Рамильевич | ИИПб-24-2                       ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                                ");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  ");
            Console.WriteLine("* выполняет указанные расчеты и печатает результат на экране               ");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите длину стороны квадрата");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                 ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CalculateSquarePerimetr(x));
            Console.ReadKey();
        }
    }
}
