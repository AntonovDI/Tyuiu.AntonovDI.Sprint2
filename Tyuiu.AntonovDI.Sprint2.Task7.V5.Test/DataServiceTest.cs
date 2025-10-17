using Tyuiu.AntonovDI.Sprint2.Task7.V5.Lib;

namespace Tyuiu.AntonovDI.Sprint2.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0.15;
            double y = 0.75;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}
