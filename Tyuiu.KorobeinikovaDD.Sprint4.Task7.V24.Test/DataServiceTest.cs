using Tyuiu.KorobeinikovaDD.Sprint4.Task7.V24.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint4.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];

            string str = "111111111111122";
            int res = ds.Calculate(n, m, str);
            int wait = 4;
          
            Assert.AreEqual(wait, res);
        }
    }
}