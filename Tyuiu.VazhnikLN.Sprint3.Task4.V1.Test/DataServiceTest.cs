using Tyuiu.VazhnikLN.Sprint3.Task4.V1.Lib;
namespace Tyuiu.VazhnikLN.Sprint3.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x1, x2;
            x1 = -5;
            x2 = 5;
            double res = ds.Calculate(x1, x2);
            Assert.AreEqual(0.962, res);
        }
    }
}
