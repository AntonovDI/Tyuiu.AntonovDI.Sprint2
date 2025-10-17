﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AntonovDI.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (((x < 0) && (y >= Math.Pow(x, 2)) && (y <= Math.Exp(x))) || ((x >= 0) && (y >= Math.Pow(x, 2)) && (y <= (Math.Exp(-x)))))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
