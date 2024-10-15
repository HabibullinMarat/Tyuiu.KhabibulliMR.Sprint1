using Tyuiu.KhabibulliMR.Sprint1.Task6.V17.Lib;

namespace Tyuiu.KhabibulliMR.Sprint1.Task6.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите строку:");
            string value = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                 ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CheckPalindrome(value));
            Console.ReadKey();
        }
    }
}
