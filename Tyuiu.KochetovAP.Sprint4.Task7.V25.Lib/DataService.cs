using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KochetovAP.Sprint4.Task7.V25.Lib
{
    public class DataService : ISprint4Task7V25
    {
        public int Calculate(int n, int m, string value)
        {
            int sumEven = 0;

            for (int i = 0; i < value.Length; i++)
            {
                int number = int.Parse(value[i].ToString());

                if (number % 2 == 0)
                {
                    sumEven += number;
                }
            }

            return sumEven;
        }
    }
}
