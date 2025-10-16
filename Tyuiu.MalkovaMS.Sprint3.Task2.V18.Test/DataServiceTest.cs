using Tyuiu.MalkovaMS.Sprint3.Task2.V18.Lib;
namespace Tyuiu.MalkovaMS.Sprint3.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 1;
            int start = 1;
            int end = 14;
            Assert.AreEqual(287.18, ds.GetMultiplySeries(value, start, end));

        }
    }
}
