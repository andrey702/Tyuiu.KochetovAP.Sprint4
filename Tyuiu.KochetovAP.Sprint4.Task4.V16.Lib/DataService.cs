using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KochetovAP.Sprint4.Task4.V16.Lib
{
    public class DataService : ISprint4Task4V16
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            
            int[,] resultArray = (int[,])matrix.Clone();

            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (resultArray[i, j] % 2 == 0)
                    {
                        resultArray[i, j] = 1;
                    }
                }
            }

            return resultArray;
        }
    }
}
