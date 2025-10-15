using Tyuiu.MalkovaMS.Sprint3.Task1.V25.Lib;

namespace Tyuiu.MalkovaMS.Sprint3.Task1.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 2;
            int start = 1;
            int end = 6;
            Assert.AreEqual(459914.329, ds.GetMultiplySeries(value, start, end));
        }
    }
}
