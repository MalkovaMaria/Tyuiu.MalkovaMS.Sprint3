using Tyuiu.MalkovaMS.Sprint3.Task6.V23.Lib;

namespace Tyuiu.MalkovaMS.Sprint3.Task6.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int StartValue = 18;
            int StopValue = 28;
            Assert.AreEqual(34, ds.GetSumTheDivisors(StartValue, StopValue));
        }
    }
}
