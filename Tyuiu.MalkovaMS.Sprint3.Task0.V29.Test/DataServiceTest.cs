using Tyuiu.MalkovaMS.Sprint3.Task0.V29.Lib;

namespace Tyuiu.MalkovaMS.Sprint3.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.5;
            int start = 1;
            int end = 10;
            double wait = 2.065;
            Assert.AreEqual(wait, ds.GetSumSeries(value, start, end));
        }
    }
}
