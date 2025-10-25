using Tyuiu.MalkovaMS.Sprint3.Task5.V12.Lib;

namespace Tyuiu.MalkovaMS.Sprint3.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 5;
            int start1 = 1;
            int stop1 = 3;
            int start2 = 1;
            int stop2 = 10;

            Assert.AreEqual(70.748, ds.GetSumSumSeries(x, start1, start2, stop1, stop2));
        }
    }
}
