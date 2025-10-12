using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AntonovDI.Sprint2.Task1.V21.Lib
{
    public class DataService : ISprint2Task1V21
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a > b) | (b == c);
            res[1] = (a != b) & (d >= a);
            res[2] = (a == b) || (d >= a);
            res[3] = (a <= b) && (d >= c);
            res[4] = !(res[0]);
            res[5] = (a == c) ^ (c > d);
            return res;
        }
    }
}
