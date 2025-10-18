using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KochetovAP.Sprint4.Task3.V5.Lib
{
    public class DataService : ISprint4Task3V5
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int sum = 0;

            
            for (int i = 0; i < rows; i++)
            {
                sum += array[i, 0];
            }

            return sum;
        }
    }
}
