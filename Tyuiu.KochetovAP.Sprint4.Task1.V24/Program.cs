using System;
using Tyuiu.KochetovAP.Sprint4.Task1.V24.Lib;

namespace Tyuiu.KochetovAP.Sprint4.Task1.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Кочетов А. П. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Кочетов А. П. | ИБКСб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов, заполненный       *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 5. Подсчитать произведение *");
            Console.WriteLine("* нечетных элементов массива.                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Создаем массив из 16 элементов
            int[] array = new int[16];

            Console.WriteLine("Введите 16 целых чисел в диапазоне от 2 до 5:");

            // Ввод данных с клавиатуры
            for (int i = 0; i < array.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Введите значение {i + 1}: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int number))
                    {
                        if (number >= 2 && number <= 5)
                        {
                            array[i] = number;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: число должно быть в диапазоне от 2 до 5!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: введите целое число!");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Введенный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                    Console.Write(", ");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int res = ds.Calculate(array);
            Console.WriteLine("Произведение нечетных элементов массива = " + res);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ПРИМЕР РАБОТЫ С ТЕСТОВЫМИ ДАННЫМИ:                                      *");
            Console.WriteLine("***************************************************************************");

            // Тестируем с вашими данными
            int[] testArray = { 2, 2, 2, 5, 5, 3, 4, 2, 5, 2, 5, 3, 4, 3, 5, 2 };
            int testResult = ds.Calculate(testArray);

            Console.WriteLine("Тестовый массив: {2, 2, 2, 5, 5, 3, 4, 2, 5, 2, 5, 3, 4, 3, 5, 2}");
            Console.WriteLine("Произведение нечетных элементов тестового массива = " + testResult);

            Console.ReadKey();
        }
    }
}