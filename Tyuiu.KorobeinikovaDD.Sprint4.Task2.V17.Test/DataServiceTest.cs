using Tyuiu.KorobeinikovaDD.Sprint4.Task2.V17.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint4.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] Array = { 3, 4, 4, 6, 6, 8, 8, 9, 4 };

            int res = ds.Calculate(Array);
            int wait = 27;
            Assert.AreEqual(wait, res);
        }
    }
}