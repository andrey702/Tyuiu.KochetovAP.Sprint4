using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KochetovAP.Sprint4.Task5.V12.Lib
{
    public class DataService : ISprint4Task5V12
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int negativeCount = 0;

            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    
                    if (matrix[i, j] < 0)
                    {
                        negativeCount++;
                    }
                }
            }

            return negativeCount;
        }
    }
}
