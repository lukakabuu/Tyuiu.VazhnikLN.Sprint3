using Tyuiu.VazhnikLN.Sprint3.Task6.V3.Lib;
namespace Tyuiu.VazhnikLN.Sprint3.Task6.V3.Test
{
    [TestClass]
    public sealed class DataSeviceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int start = 13;
            int stop = 19;
            int res = ds.GetSumTheDivisors(start, stop);
            Assert.AreEqual(121, res);

        }
    }
}
