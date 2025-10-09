﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AntonovDI.Sprint2.Task0.V9.Lib
{
    public class DataService : ISprint2Task0V9
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x - 679 == y;
            res[1] = x != y;
            res[2] = x > y;
            res[3] = x - 1000 < y;
            res[4] = x >= y;
            res[5] = x <= y;
            return res;
        }
    }
}
