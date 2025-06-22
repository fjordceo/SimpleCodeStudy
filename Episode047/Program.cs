namespace Episode047;
/*
 * Функции и методы в C#
 */

// Функция - это блок кода, который выполняет определенную задачу и может возвращать значение.
// Метод - это функция, которая связана с определенным классом и может использовать его данные.

/* Модификаторы тип_возвращаемого_значения название_метода(параметры)
 * {
 *     // Тело метода
 * }
 * 
 * void - метод ничего не возвращает
 * int - метод возвращает целое число
 * string - метод возвращает строку
 * bool - метод возвращает логическое значение
 * 
 */


class Program
{
    
    static void Main(string[] args)
    {
        int a, b, c;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        c = Sum(a, b);
        PrintResult(c);
        
        PrintLine();
    }
    
    static int Sum (int firstValue, int secondValue)
    {
        int result = firstValue + secondValue;
        return result;
        
    }

    static void PrintLine()
    {
        Console.WriteLine("Метод PrintLine вызван");
    }

    static void PrintResult(int result)
    {
        Console.WriteLine($"Результат сложения: {result}");
    }
}

/*
 * 1. Написать метод, который выводит на экран строку.
 *    Символы, из которых состоит строка, и их количество вводятся пользователем.
 *
 * 2. Написать метод для поиска индекса элемента массива (тип элементов в массиве - int),
 *    Метод должен вернуть индекс первого найденного элемента, если он будет найден.
 */