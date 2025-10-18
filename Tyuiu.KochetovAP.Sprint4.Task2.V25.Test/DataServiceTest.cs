using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KochetovAP.Sprint4.Task2.V25.Lib;

namespace Tyuiu.KochetovAP.Sprint4.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 4, 5, 6, 7, 8, 3, 4, 9, 6, 5, 4 };

           

            int wait = 18432;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateNoEvenElements()
        {
            DataService ds = new DataService();

            int[] array = { 3, 5, 7, 9, 3, 5, 7, 9, 3, 5, 7 };

            

            int wait = 0;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateSingleEvenElement()
        {
            DataService ds = new DataService();

            int[] array = { 3, 5, 4, 7, 9, 3, 5, 7, 9, 3, 5 };

            

            int wait = 4;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateAllEvenElements()
        {
            DataService ds = new DataService();

            int[] array = { 4, 6, 8, 4, 6, 4, 8, 6, 4, 8, 6 };

            

            int wait = 4 * 6 * 8 * 4 * 6 * 4 * 8 * 6 * 4 * 8 * 6;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}