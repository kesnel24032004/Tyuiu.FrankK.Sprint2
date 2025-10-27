using Tyuiu.FrankK.Sprint2.Task5.V5.Lib;
namespace Tyuiu.FrankK.Sprint2.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 12;
            string c = ds.FindCardValue(x);
            Assert.AreEqual("дама",c);
        }
    }
}
