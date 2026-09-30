using System.Transactions;
using Tyuiu.VazhnikLN.Sprint3.Task1.V22.Lib;
namespace Tyuiu.VazhnikLN.Sprint3.Task1.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double a = 1.5;
            int k = 1;
            int z = 20;
            double res = ds.GetSumSeries(a, k, z);
            double wait = 3550.571;
            Assert.AreEqual(wait, res);
        }
    }
}
