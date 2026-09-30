using Tyuiu.VazhnikLN.Sprint3.Task2.V25.Lib;
namespace Tyuiu.VazhnikLN.Sprint3.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int n = 5;
            int k = 1;
            int z = 13;
            double res = ds.GetSumSeries(n, k, z);
            Assert.AreEqual(16.016, res);
        }
    }
}
