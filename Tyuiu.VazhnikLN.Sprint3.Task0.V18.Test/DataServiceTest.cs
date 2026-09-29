using Tyuiu.VazhnikLN.Sprint3.Task0.V18.Lib;
namespace Tyuiu.VazhnikLN.Sprint3.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int x, y, z;
            x = 1;
            y = 1;
            z = 6;
            double res = ds.GetMultiplySeries(x, y, z);
            double wait = 914700.94;
            Assert.AreEqual(wait, res);
        }
    }
}
