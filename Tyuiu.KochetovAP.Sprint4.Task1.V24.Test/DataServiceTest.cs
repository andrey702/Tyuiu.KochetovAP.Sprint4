using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KochetovAP.Sprint4.Task1.V24.Lib;

namespace Tyuiu.KochetovAP.Sprint4.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 2, 2, 2, 5, 5, 3, 4, 2, 5, 2, 5, 3, 4, 3, 5, 2 };

           

            int wait = 84375;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}