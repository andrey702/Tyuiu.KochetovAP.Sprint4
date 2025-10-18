using System;
using Tyuiu.KochetovAP.Sprint4.Task5.V12.Lib;

namespace Tyuiu.KochetovAP.Sprint4.Task5.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнил: Кочетов А. П. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Кочетов А. П. | ИБКСб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный случайными значениями в диапазоне от -6 до 4.               *");
            Console.WriteLine("* Найти количество отрицательных элементов.                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5];

            Console.WriteLine("Исходный массив 5x5 (диапазон значений от -6 до 4):");
            Console.WriteLine(new string('-', 54));

            for (int i = 0; i < 5; i++)
            {
                Console.Write("|");
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rnd.Next(-6, 5);
                    Console.Write($"{matrix[i, j],4} |");
                }
                Console.WriteLine();
                Console.WriteLine(new string('-', 54));
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(matrix);

            Console.WriteLine($"Количество отрицательных элементов в массиве = {result}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ПРОГРАММА ЗАВЕРШЕНА                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}