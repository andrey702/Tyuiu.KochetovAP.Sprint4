
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KochetovAP.Sprint4.Task2.V25.Lib
{
    public class DataService : ISprint4Task2V25
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasEvenElements = false;

            
            for (int i = 0; i < array.Length; i++)
            {
                
                if (array[i] % 2 == 0)
                {
                    product *= array[i]; 
                    hasEvenElements = true; 
                }
            }

            
            return hasEvenElements ? product : 0;
        }
    }
}
