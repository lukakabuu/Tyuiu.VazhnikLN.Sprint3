using Tyuiu.VazhnikLN.Sprint3.Task5.V11.Lib;
namespace Tyuiu.VazhnikLN.Sprint3.Task5.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int startvalue1 = 1;
            int startvalue2 = 1;
            int stopvalue1 = 3;
            int stopvalue2 = 10;
            int x = 5;
            double res = ds.GetSumSumSeries(x, startvalue1, startvalue2, stopvalue1, stopvalue2);
            Assert.AreEqual(64.234, res);
        }
    }
}
