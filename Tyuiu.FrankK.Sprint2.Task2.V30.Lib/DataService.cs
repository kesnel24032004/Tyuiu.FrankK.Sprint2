using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FrankK.Sprint2.Task2.V30.Lib
{
    public class DataService : ISprint2Task2V30
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((x>=3&x<=5&y>=3&y<=7)||(x==2&y>=4&y<=6)||(x>=6&x<=8&y>=5&y<=7)||(x>=9&x<=12&y>=3&y<=7)||(x==13&y>=6&y<=7)||(x==6&y>=5&y<=11)||(x>=3&x<=12&y==11)||(x>=7&x<=10&y==12))


                res = true;
            else
                res = false;
            return res;
        }
    }
}
