using Tyuiu.KhabibulliMR.Sprint1.Task3.V8.Lib;

namespace Tyuiu.KhabibulliMR.Sprint1.Task3.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Хабибуллин М. Р. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                ");
            Console.WriteLine("* Тема : Операторы составного присваивания                                 ");
            Console.WriteLine("* Задание #3                                                               ");
            Console.WriteLine("* Вариант #8                                                               ");
            Console.WriteLine("* Выполнил : Хабибуллин Марат Рамильевич | ИИПб-24-2                       ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                                ");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  ");
            Console.WriteLine("* выполняет указанные расчеты и печатает результат на экране               ");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            int startAmount = 2500;
            Console.WriteLine("Величина вклада (руб.) -> ", + startAmount);
            int percent = 20;
            Console.WriteLine("Процентная ставка (годовых) -> " + percent);
            int timeDays = 30;
            Console.WriteLine("Срок вклада (дней) ->" + timeDays);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                 ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.IncomeAmount(startAmount,percent,timeDays));
            Console.ReadKey();
        }
    }
}
