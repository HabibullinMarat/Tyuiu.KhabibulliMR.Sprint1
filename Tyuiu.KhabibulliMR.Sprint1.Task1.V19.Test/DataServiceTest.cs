using Tyuiu.KhabibulliMR.Sprint1.Task1.V19.Lib;

namespace Tyuiu.KhabibulliMR.Sprint1.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(6, res);
        }
    }
}