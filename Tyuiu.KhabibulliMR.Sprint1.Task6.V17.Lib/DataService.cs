using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhabibulliMR.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            char[] chars = value.ToCharArray();
            Array.Reverse(chars);
            string eulav = new string(chars);
            if (eulav == value)
            {
                return true;
            }
            else {return false;}
        }
    }
}
