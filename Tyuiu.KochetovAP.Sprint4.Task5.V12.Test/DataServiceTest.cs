
using Tyuiu.KochetovAP.Sprint4.Task5.V12.Lib;

namespace Tyuiu.KochetovAP.Sprint4.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
                { -1, 2, -3, 4, -5 },
                { 1, -2, 3, -4, 5 },
                { -6, 0, 2, -1, 3 },
                { 4, -3, 1, -2, 0 },
                { -4, 2, -1, 3, -6 }
            };

            int result = ds.Calculate(matrix);
            int wait = 12; 

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateNoNegatives()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
                { 0, 1, 2, 3, 4 },
                { 1, 2, 3, 4, 0 },
                { 2, 3, 4, 0, 1 },
                { 3, 4, 0, 1, 2 },
                { 4, 0, 1, 2, 3 }
            };

            int result = ds.Calculate(matrix);
            int wait = 0; 

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateAllNegatives()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
                { -1, -2, -3, -4, -5 },
                { -1, -2, -3, -4, -5 },
                { -1, -2, -3, -4, -5 },
                { -1, -2, -3, -4, -5 },
                { -1, -2, -3, -4, -5 }
            };

            int result = ds.Calculate(matrix);
            int wait = 25; 

            Assert.AreEqual(wait, result);
        }
    }
}