using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AntonovDI.Sprint2.Task4.V13.Lib
{
    public class DataService : ISprint2Task4V13
    {
        public double Calculate(double x, double y)
        {
            double a = Math.Pow(x, 2) + Math.Cos(y * y) + 13;
            double b = Math.Pow(y, 2) - Math.Sin(y * y) + 9;
            double z = (Math.Sqrt(x) * 3 > y * 2 - 20) ? (x + 10*y - (1/x)) : (a/b);
            return Math.Round(z, 3);
        }
    }
}
