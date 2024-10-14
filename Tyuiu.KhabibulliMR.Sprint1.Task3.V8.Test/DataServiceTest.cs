using Tyuiu.KhabibulliMR.Sprint1.Task3.V8.Lib;

namespace Tyuiu.KhabibulliMR.Sprint1.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2500;
            int y = 30;
            int rate = 20;
            double res = Math.Round(ds.IncomeAmount(x, rate, y),3);
            Assert.AreEqual(41.096, res);
        }
    }
}