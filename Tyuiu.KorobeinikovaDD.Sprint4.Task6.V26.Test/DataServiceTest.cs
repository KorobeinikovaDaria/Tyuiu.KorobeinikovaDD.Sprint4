using Tyuiu.KorobeinikovaDD.Sprint4.Task6.V26.Lib;
namespace Tyuiu.KorobeinikovaDD.Sprint4.Task6.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] Array = new string[] { "������", "������", "�����", "����", "���" };

            string[] res = ds.Calculate(Array);
            string[] wait =["������", "������"];
            CollectionAssert.AreEqual(wait, res);
        }
    }
}