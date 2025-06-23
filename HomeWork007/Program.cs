namespace HomeWork007;

/*
 * 1. Написать метод, который выводит на экран строку.
 *    Символы, из которых состоит строка, и их количество вводятся пользователем.
 *
 * 2. Написать метод для поиска индекса элемента массива (тип элементов в массиве - int),
 *    Метод должен вернуть индекс первого найденного элемента, если он будет найден.
 */

class Program
{
    static void Main(string[] args)
    {
        int numberToFind;
        char symbol;
        int count;

        int[] myArrey = GetRandomArray(15, 1, 100);
        
        
        Console.WriteLine("Введите символ, из которого будет состоять строка:");
        symbol = Console.ReadKey().KeyChar;
        Console.WriteLine("\nВведите количество символов в строке:");
        count = int.Parse(Console.ReadLine());
        
        WriteString(symbol, count);
        
        Console.WriteLine("У нас есть вот такой массив случайных чисел:");
        for (int i = 0; i < myArrey.Length; i++)
        {
            Console.Write(myArrey[i] + " ");
        }
        Console.WriteLine();
        
        
        Console.WriteLine("Введите число, индекс которого нужно найти в массиве:");
        numberToFind = int.Parse(Console.ReadLine());

        Console.WriteLine($"Индекс введенного вами числа в массиве: {FindIndex(myArrey, numberToFind)}");
    }
    
    static void WriteString(char symbol, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write(symbol);
        }
        Console.WriteLine();
    }
    
    static int FindIndex(int[] myArray, int numberToFind)
    {
        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] == numberToFind)
            {
                return i; // Возвращаем индекс первого найденного элемента
            }
        }
        return -1; // Если элемент не найден, возвращаем -1
    }
    
    static int[] GetRandomArray(int length, int minValue, int maxValue)
    {
        Random random = new Random();
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(minValue, maxValue);
        }
        return array;
    }
}