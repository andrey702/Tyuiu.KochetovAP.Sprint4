using System;
using Tyuiu.KochetovAP.Sprint4.Task7.V25.Lib;

namespace Tyuiu.KochetovAP.Sprint4.Task7.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Кочетов А. П. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Кочетов Андрей Павлович | ИБКСб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр '348561792486'. Преобразуйте ее в    *");
            Console.WriteLine("* матрицу 4 на 3 и подсчитайте сумму четных чисел.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "348561792486";
            int n = 4;
            int m = 3;

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Количество строк = " + n);
            Console.WriteLine("Количество столбцов = " + m);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n, m, value);

            Console.WriteLine("Сумма четных элементов матрицы = " + res);
            Console.ReadKey();
        }
    }
}
