using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhabibulliMR.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int SecondsToHours(int time)
        {
            int hours  = Convert.ToInt32(time / 3600);
            return hours;
        }
    }
}
