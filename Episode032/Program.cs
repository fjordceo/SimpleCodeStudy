namespace Episode032;
/*
 * Массивы
 *
 * Одномерные массивы
 *
 * Тип_элементов_массива [] имя_массива
 */

class Program
{
    static void Main(string[] args)
    {

        int[] myArray;
        myArray = new int[5];
        myArray[0] = 5;
        myArray[1] = 10;
        
        Console.WriteLine(myArray.Length);
    }
}