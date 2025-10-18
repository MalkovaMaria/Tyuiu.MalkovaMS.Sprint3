using Tyuiu.MalkovaMS.Sprint3.Task3.V27.Lib;

namespace Tyuiu.MalkovaMS.Sprint3.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();
            string value = "!bt, g567kid f!";
            int wait = 567;
            Assert.AreEqual(wait, ds.ConvertStringToInt(value));
        }
    }
}
