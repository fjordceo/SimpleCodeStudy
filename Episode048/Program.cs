namespace Episode048;

/*
 * Перегрузка методов в C#
 */

class Program
{
    static void Main(string[] args)
    {
        int result = Sum(10, 15); // Вызов перегруженного метода Sum с двумя параметрами
        Console.WriteLine ($"Результат сложения двух чисел: {result}");
        result = Sum(10, 15, 20); // Вызов перегруженного метода Sum с тремя параметрами
        Console.WriteLine ($"Результат сложения трех чисел: {result}");
        double resultDouble = Sum(10.5, 15.5); // Вызов перегруженного метода Sum с двумя параметрами типа double
        Console.WriteLine($"Результат сложения двух чисел типа double: {resultDouble}");
    }

    /// <summary>
    /// Возвращает сумму трех целых чисел.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    static int Sum(int a, int b, int c) 
    {
        return a + b + c;
    }

    /// <summary>
    /// Возвращает сумму двух целых чисел.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    static int Sum(int a, int b)
    {
        return a + b;
    }
    
    /// <summary>
    /// Возвращает сумму двух чисел типа double.
    /// </summary> 
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    static double Sum (double a, double b) // Перегрузка метода Sum c использованием типа double
    {
        return a + b;
    }
}