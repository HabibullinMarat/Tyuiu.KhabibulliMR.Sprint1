using Tyuiu.KhabibulliMR.Sprint1.Task5.V4.Lib;

namespace Tyuiu.KhabibulliMR.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 13257;
            int res = ds.SecondsToHours(x);
            Assert.AreEqual(3, res);
        }
    }
}