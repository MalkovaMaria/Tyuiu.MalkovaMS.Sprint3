using Tyuiu.MalkovaMS.Sprint3.Task4.V12.Lib;

namespace Tyuiu.MalkovaMS.Sprint3.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            Assert.AreEqual(467.59, ds.Calculate(start, end));
        }
    }
}
