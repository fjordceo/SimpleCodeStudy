namespace Episode011;

/*
 * Операторы. Арифметические операции с числами.
 */

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 3;
        int c = 5;
        float result;
        
        result = a + b;
        Console.WriteLine(result);
        
        
        result = (float) a / b;
        Console.WriteLine(result);
        
        result = a % b;
        Console.WriteLine(result);

        result = a + b + c;
        Console.WriteLine(result);

        result = a + 5;
        Console.WriteLine(result);
    }
}

// Домашнее задание
// 1. Напишите программу вычисляющую среднее арифметическое двух чисел.
// 2. Введите три числа и выведите на экран значение суммы и произведения этих чисел
// 3. Напишите простой конвертер валют (без возможности динамического выбора валюты пользователем)