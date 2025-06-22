namespace Episode045;

/*
 * Ступенчатые (зубчатые) массивы. Одномерный массив, состоящий из одномерных массивов.
 */

class Program
{
    static void Main(string[] args)
    {
        int[][] myArray = new int [3][]; // Массив из массивов
        
        myArray[0] = new int[2];
        myArray[1] = new int[6];
        myArray[2] = new int[3];
        
        // Заполнение массива случайными числами от 1 до 100
        Random random = new Random();
        
        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = 0; j < myArray[i].Length; j++)
            {
                myArray[i][j] = random.Next(100);
            }
        }

        Console.WriteLine("Выводим значения элементов зубчатого массива myArray:");
        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = 0; j < myArray[i].Length; j++)
            {
                Console.Write($"{myArray[i][j]}\t");
            }
            Console.WriteLine();
        }
    }
}