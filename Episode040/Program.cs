namespace Episode040;
/*
 * Индексы и диапазоны
 */

class Program
{
    static void Main(string[] args)
    {
        int[] myArray = [10, 122, 3, 2, 55, 15, 28, 122, 30, 68, 12, 122,113];

        Index myIndex = ^2;
        
        Console.WriteLine($"Value {myIndex.Value}, isFromEnd {myIndex.IsFromEnd}");
        Console.WriteLine(myArray[myIndex]); //Индекс. В данном случае второй элемент с конца
        Console.WriteLine(myArray[^1]); //Индекс. Первый элемент с конца
        
        int[] myArray1 = myArray[1..4]; // Диапазон массива
        int[] myArray2 = myArray[..4]; // Диапазон от 0 элемента до 4
        
        //Помни! String это массив из char!
        
        
        
        
        
        
        
    }
}