using Tyuiu.KorobeinikovaDD.Sprint4.Task0.V19.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint4.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataService ds = new DataService();
            int[] nArray = { 1, 2, 3, 4, 5 };
            int res = ds.GetMultOddArrEl(nArray);
            int wait = 15;
            Assert.AreEqual(wait, res);
        }
    }
}