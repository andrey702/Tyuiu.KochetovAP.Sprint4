using System;
using Tyuiu.KochetovAP.Sprint4.Task2.V25.Lib;

namespace Tyuiu.KochetovAP.Sprint4.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Кочетов А. П. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                            *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Кочетов А. П. | ИБКСб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов, заполненный       *");
            Console.WriteLine("* случайными значениями в диапазоне от 3 до 9. Подсчитать произведение   *");
            Console.WriteLine("* четных элементов массива.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            
            DataService ds = new DataService();
            int[] array = new int[11];

            Random random = new Random();
            Console.WriteLine("Массив из 11 элементов (случайные числа от 3 до 9):");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(3, 10); 
                Console.Write(array[i]);
                if (i < array.Length - 1)
                    Console.Write(", ");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);
            Console.WriteLine("Произведение четных элементов массива = " + res);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ПРИМЕР РАБОТЫ:                                                          *");
            Console.WriteLine("***************************************************************************");

            
            int[] testArray = { 4, 5, 6, 7, 8, 3, 4, 9, 6, 5, 4 };
            int testResult = ds.Calculate(testArray);

            Console.WriteLine("Пример массива: {4, 5, 6, 7, 8, 3, 4, 9, 6, 5, 4}");
            Console.WriteLine("Четные элементы: 4, 6, 8, 4, 6, 4");
            Console.WriteLine("Произведение четных элементов = " + testResult);
            Console.WriteLine("Проверка: 4 × 6 × 8 × 4 × 6 × 4 = 18432");

            Console.ReadKey();
        }
    }
}