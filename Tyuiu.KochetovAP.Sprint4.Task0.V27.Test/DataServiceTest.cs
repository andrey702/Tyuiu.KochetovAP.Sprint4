using Tyuiu.KochetovAP.Sprint4.Task0.V27.Lib;

namespace Tyuiu.KochetovAP.Sprint4.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int res = ds.GetMultOddArrEl(array);
            Assert.AreEqual(6615, res);
        }
    }
}