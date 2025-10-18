using System;
using Tyuiu.KochetovAP.Sprint4.Task4.V16.Lib;

namespace Tyuiu.KochetovAP.Sprint4.Task4.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Кочетов А. П. | ИБКСб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Кочетов Андрей Павлович | ИБКСб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный       *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 7. Заменить четные         *");
            Console.WriteLine("* элементы массива на 1.                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[5, 5];

            Console.WriteLine("Введите элементы массива 5x5 (числа от 3 до 7):");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    while (true)
                    {
                        Console.Write($"Введите элемент [{i},{j}]: ");
                        string input = Console.ReadLine();

                        if (int.TryParse(input, out int number))
                        {
                            if (number >= 3 && number <= 7)
                            {
                                array[i, j] = number;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка! Число должно быть в диапазоне от 3 до 7.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ошибка! Введите целое число.");
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Введенный массив:");
            PrintArray(array);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int[,] result = ds.Calculate(array);

            Console.WriteLine("Массив после замены четных элементов на 1:");
            PrintArray(result);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}