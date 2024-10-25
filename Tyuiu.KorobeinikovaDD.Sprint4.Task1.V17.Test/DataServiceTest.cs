using Tyuiu.KorobeinikovaDD.Sprint4.Task1.V17.Lib;

namespace Tyuiu.KorobeinikovaDD.Sprint4.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] Array = { 2, 4, 1, 5 };

            int res = ds.Calculate(Array);
            int wait = 6;
            Assert.AreEqual(wait, res);
        }
    }
}