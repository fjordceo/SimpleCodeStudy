using System.Globalization;

namespace Episode029;

/*
 * Вложенные циклы (вложенные конструкции). Используются, например, в двумерных или трехмерных массивах
 * Работа с вложенными данными в ООП
 */


class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Цикл №1. Итерация " + i);
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine("\tЦикл №2. Итерация " + j);
            }
        }

        Console.WriteLine();

        Console.Write("Введите высоту прямоугольника: ");
        int height = int.Parse(Console.ReadLine());
        Console.Write("Введите ширину прямоугольника: ");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine();
        
        for (int a = 0; a < height; a++)
        {
            for (int b = 0; b < width; b++)
            {
                Console.Write("+");
            }
            Console.WriteLine();
        }
    }
}

// Отрисовать в консоли треуголники из # только с помощью вложенных циклов без if else