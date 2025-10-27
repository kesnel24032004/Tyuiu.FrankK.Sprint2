using Tyuiu.FrankK.Sprint2.Task7.V9.Lib;
namespace Tyuiu.FrankK.Sprint2.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.1;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}
