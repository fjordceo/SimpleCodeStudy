using System.Globalization;

namespace Episode039;
/*
 * Как работать с массивами в C# на самом деле
 * LINQ. Extension методы
 */

class Program
{
    static void Main(string[] args)
    {
        // Найти минимальный элемент массива
        int[] myArray = [10, 122, 3, 2, 55, 15, 28, 122, 30, 68, 12, 122];
        Console.WriteLine($"Минимальный элемент массива: {myArray.Min()}");
        Console.WriteLine($"Максимальный элемент массива: {myArray.Max()}");
        Console.WriteLine($"Сумма элементов массива: {myArray.Sum()}");
        Console.WriteLine($"Сумма всех четных элементов массива: {myArray.Where(x => x % 2 == 0).Sum()}");
        Console.WriteLine($"Минимальное нечетное число массива: {myArray.Where(x => x % 2 != 0).Min()}");
        Console.WriteLine($"Минимальное четное число массива: {myArray.Where(x => x % 2 == 0).Min()}");
        
        int[]result = myArray.Distinct().ToArray(); //Получение уникальных элементов массива, перенос их в другой массив. Избавляемся от повторяющихся элементов
        Console.WriteLine("Уникальные элементы массива: ");
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write($"{result[i]} ");
        }
        
        //Сортировка массива. OrderByDescending - для сортировки с наибольшего к меньшему
        Console.WriteLine("\nСортировка массива:");
        result= myArray.OrderBy(x => x).ToArray();
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write($"{result[i]} ");
        }
        
        Array.Sort(myArray); //Вариант сортировки массива через класс Array
        int result1 = Array.Find(myArray, i => i > 30); //Вариант поиска первого значения меньше 30 в массиве через класс Array
       
        int result2 = Array.FindLast(myArray, i => i > 30); //Вариант поиска первого с конца значения меньше 30 в массиве через класс Array
        int[] result3 = Array.FindAll(myArray, i => i > 50); // Находит и добавляет в новый массив все числа, которые больше 50
        int result4 = Array.FindIndex(myArray, i => i == 55); // Находит индекс первого совпадения числа в массиве, обратный метод FindLastIndex
        Array.Reverse(myArray);
        
        
        Console.WriteLine();
        Console.WriteLine($"Первое значение, которое больше 30: {result1}");
        Console.WriteLine($"Первое с конца значение, которое больше 30: {result2}");
        Console.WriteLine($"Индекс первого числа, которое равно 55: {result4}");
        
        Console.WriteLine("Выводим массив в обратном порядке: ");
        for (int j = 0; j < myArray.Length; j++)
        {
            Console.Write($"{myArray[j]} ");
        }
        
        
        
        int [] result11 = myArray.Where(i => i < 70).ToArray();
        //Лучше использовать LinQ
        
        
        
        
    }
}