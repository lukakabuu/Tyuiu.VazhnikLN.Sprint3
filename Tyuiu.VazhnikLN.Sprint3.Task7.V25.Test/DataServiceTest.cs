using Tyuiu.VazhnikLN.Sprint3.Task7.V25.Lib;
namespace Tyuiu.VazhnikLN.Sprint3.Task7.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            double[] res = ds.GetMassFunction(start, end);
            double[] wait = { 4.67, 0.43, -8.26, -9.87, -3.98, 1, 0.02, -1.87, 3.74, 16.43, 24.67 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
