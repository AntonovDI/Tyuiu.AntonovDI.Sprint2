using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AntonovDI.Sprint2.Task2.V28.Lib
{
    public class DataService : ISprint2Task2V28
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (y == 2) return ((x > 9) && (x < 14));
            if (y == 3) return ((x > 2) && (x < 6)) || ((x > 9) && (x < 14));
            if (y == 4) return ((x > 1) && (x < 6)) || ((x > 9) && (x < 13));
            if (y == 5) return ((x > 1) && (x < 13));
            if (y == 6) return ((x > 2) && (x < 9));
            if (y == 7) return ((x > 2) && (x < 9));
            if (y == 8) return ((x > 5) && (x < 9));
            if (y == 9) return ((x > 5) && (x < 9)) || (x == 13);
            if (y == 10) return ((x > 5) && (x < 9)) || (x == 13);
            if (y == 11) return ((x > 2) && (x < 14));
            if (y == 12) return ((x > 6) && (x < 11)) || (x == 13);
            if (y == 13) return (x == 13);

            return false;
        }
    }
}
