using Tyuiu.KorobeinikovaDD.Sprint4.Task3.V17.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint4.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] Array = new int[5, 5]{ { 3, 4, 4, 1, 6 },
                                           {8, 8, 9, 1, 3 },
                                           {8, 8, 9, 1, 3 },
                                           {8, 8, 9, 1, 3 },
                                           { 5, 8, 9, 1, 3 } };

            int res = ds.Calculate(Array);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}