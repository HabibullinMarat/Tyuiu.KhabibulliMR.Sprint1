using Tyuiu.KhabibulliMR.Sprint1.Task6.V17.Lib;

namespace Tyuiu.KhabibulliMR.Sprint1.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();

            string x = "abcba";
            bool res = ds.CheckPalindrome(x);
            Assert.AreEqual(true, res);
        }
    }
}