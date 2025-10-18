
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KochetovAP.Sprint4.Task1.V24.Lib
{
    public class DataService : ISprint4Task1V24
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasOddElements = false;

            foreach (int number in array)
            {
                if (number % 2 != 0) 
                {
                    product *= number;
                    hasOddElements = true;
                }
            }

            
            return hasOddElements ? product : 0;
        }
    }
}
