using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhabibulliMR.Sprint1.Task3.V8.Lib
{
    public class DataService : ISprint1Task3V8
    {
        public double IncomeAmount(double startAmount, double percent, double timeDays)
        {
            return Math.Round((timeDays / 365) * (percent / 100) * startAmount,3);
        }
    }
}
