using Tyuiu.AntonovDI.Sprint2.Task4.V13.Lib;

namespace Tyuiu.AntonovDI.Sprint2.Task4.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 52.667;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 30;
            double res = ds.Calculate(x, y);
            double wait = 0.019;
            Assert.AreEqual(wait, res);
        }
    }
}
