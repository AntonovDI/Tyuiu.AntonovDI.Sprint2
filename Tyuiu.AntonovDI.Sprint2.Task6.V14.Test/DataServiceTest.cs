using Tyuiu.AntonovDI.Sprint2.Task6.V14.Lib;

namespace Tyuiu.AntonovDI.Sprint2.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string res = ds.FindDayName(1, 7);
            Assert.AreEqual("Воскресенье", res);
        }
    }
}
