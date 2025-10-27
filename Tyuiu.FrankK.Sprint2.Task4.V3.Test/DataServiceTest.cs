using Tyuiu.FrankK.Sprint2.Task4.V3.Lib;
namespace Tyuiu.FrankK.Sprint2.Task4.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 8;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(9, res);
        }
    }
}
