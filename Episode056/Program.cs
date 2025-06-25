namespace Episode056;

/*
 * Оператор условного Null (?.)
 * Проверяет, не является ли объект null, и если это так, то возвращает null, иначе выполняет доступ к члену объекта.
 */

class Program
{
    static int[] GetArray()
    {
        int[] myArray = null;
        return myArray;
    }
    
    static void Main(string[] args)
    {
        int [] myArray = GetArray();
        Console.WriteLine($"Сумма элементов массива: {myArray?.Sum()?? 0}");
    }
}