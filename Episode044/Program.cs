namespace Episode044;
/*
 * Заполнение двумерного массива с клавиатуры
 * Заполнение двумерного массива случайными числами
 */

class Program
{
    static void Main(string[] args)
    {
        int[,] my2DArray = new int[2,3];
        Random random = new Random();
        
        /*for (int y = 0; y < my2DArray.GetLength(0); y++)
        {
            for (int x = 0; x < my2DArray.GetLength(1); x++)
            {
                my2DArray[y, x] = random.Next(100); // Заполнение случайными числами от 0 до 99
            } 
            
        }
        */
       
        for (int y = 0; y < my2DArray.GetLength(0); y++)
        {
            for (int x = 0; x < my2DArray.GetLength(1); x++)
            {
                Console.Write($"Введите значение для элемента [{y}, {x}]: ");
                my2DArray [y,x] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

        }
        
        Console.WriteLine("Вывод двумерного массива на экран:");
        for (int y = 0; y < my2DArray.GetLength(0); y++)
        {
            for (int x = 0; x < my2DArray.GetLength(1); x++)
            {
                Console.Write(my2DArray[y, x] + "\t");
            }

            Console.WriteLine();

        }
    }
}
