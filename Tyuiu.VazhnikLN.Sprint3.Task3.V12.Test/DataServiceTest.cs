using Tyuiu.VazhnikLN.Sprint3.Task3.V12.Lib;
namespace Tyuiu.VazhnikLN.Sprint3.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();
            char c = 'k';
            string value = "bkkrk ckkkcs ksr";
            int res = ds.GetMaxCharCount(value, c);
            Assert.AreEqual(3, res);
        }
    }
}
