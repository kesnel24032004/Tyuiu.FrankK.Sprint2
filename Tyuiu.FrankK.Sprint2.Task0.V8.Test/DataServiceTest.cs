using Tyuiu.FrankK.Sprint2.Task0.V8.Lib;

namespace Tyuiu.FrankK.Sprint2.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 185;
            int y = 251;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] result = new bool[6] { true, false, true, false, true, false };
            CollectionAssert.AreEqual(result, res);
        }
    }
}
