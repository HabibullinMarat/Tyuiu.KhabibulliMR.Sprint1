using Tyuiu.KhabibulliMR.Sprint1.Task2.V27.Lib;

namespace Tyuiu.KhabibulliMR.Sprint1.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int x = 1;
            var res = ds.CalculateSquarePerimetr(x);
            Assert.AreEqual(4, res);
        }
    }
}