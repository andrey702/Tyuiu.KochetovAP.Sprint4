using System;
using Tyuiu.KochetovAP.Sprint4.Task6.V13.Lib;

namespace Tyuiu.KochetovAP.Sprint4.Task6.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Кочетов А. П. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Кочетов А. П. | ИБКСб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Ford\", \"Toyota\", \"Honda\",              *");
            Console.WriteLine("* \"Chevrolet\", \"Mercedes\", \"BMW\", \"Audi\"]. Используя класс Array     *");
            Console.WriteLine("* подсчитайте количество элементов, длина которых больше 4.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] cars = ["Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi"];

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"[{i}] = {cars[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.Calculate(cars);

            Console.WriteLine($"Количество элементов с длиной больше 4: {result}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}