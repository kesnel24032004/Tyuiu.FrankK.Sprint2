using Tyuiu.FrankK.Sprint2.Task6.V4.Lib;
namespace Tyuiu.FrankK.Sprint2.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.FindCardSuit(x);
            Assert.AreEqual("трефы", res);
        }
    }
}
