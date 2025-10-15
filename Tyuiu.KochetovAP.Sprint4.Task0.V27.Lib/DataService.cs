using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KochetovAP.Sprint4.Task0.V27.Lib
{
    public class DataService : ISprint4Task0V27
    {
        public int GetMultOddArrEl(int[] array)
        {
            int product = 1;
            bool hasOddElements = false;

            foreach (int element in array)
            {
                if (element % 2 != 0) 
                {
                    product *= element;
                    hasOddElements = true;
                }
            }

            return hasOddElements ? product : 0;

        }
    }
}
