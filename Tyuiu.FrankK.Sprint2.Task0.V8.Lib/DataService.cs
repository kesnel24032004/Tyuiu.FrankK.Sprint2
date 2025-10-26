﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FrankK.Sprint2.Task0.V8.Lib
{
    public class DataService : ISprint2Task0V8
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            // x = 185 y = 251
            bool[] res = new bool[6];
            res[0] = (x + (251 - 185)) == y;
            res[1] = (x + (251 - 185)) != y;
            res[2] = x < y;
            res[3] = x > y;
            res[4] = x <= y;
            res[5] = x >= y;
            return res;
        }
    }
}
