namespace Episode033;
/*
 * Массивы
 *
 * Одномерные массивы
 *
 * Способы инициализациии массивов
 */

class Program
{
    static void Main(string[] args)
    {
        //Способы инициализации массивов
        int[] myArray = new int[5]; 
        //Так же можно не указывать количество элементов массива
        int[] myArrey1 = new int[5] { 5, 6, 9, 8, 7 }; 
        //Через Enumerable. Записывает 10 элементов со значением 5
        int[] myArrey2 = Enumerable.Repeat(5, 10).ToArray();
        //Через Enumerable.Range. Создает 10 элементов со значением, начинающимся от 10.
        int[] myArrey3 = Enumerable.Range(10, 10).ToArray();
        
        


        Console.WriteLine();

    }
}