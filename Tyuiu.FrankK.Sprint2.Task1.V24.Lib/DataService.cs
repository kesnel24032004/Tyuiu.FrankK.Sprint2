using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FrankK.Sprint2.Task1.V24.Lib
{
    public class DataService : ISprint2Task1V24
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            //a=325, b=325, c=242, d=324
            bool[] res = new bool[6];
            res[0] = (a > b) | (c < d);
            res[1] = (a <= b) & ((c + (323 - 242)) == d);
            res[2] = (a > b) || (c < d);
            res[3] = (a < b) && ((c + (541 - 242)) != d);
            res[4] = !(c > d);
            res[5] = (a == b) ^ (c != d);
            return res;
        }
    }
}
