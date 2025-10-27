using Tyuiu.FrankK.Sprint2.Task3.V22.Lib;
namespace Tyuiu.FrankK.Sprint2.Task3.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3;
            var res = ds.Calculate(x);
            Assert.AreEqual(30, res);
        }
    }
}
