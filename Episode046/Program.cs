namespace Episode046;
/*
 * Трехмерные массивы. Массив, состоящий из двумерных массивов.
 */

class Program
{
    static void Main(string[] args)
    {
        int [,,] my3DArray = new int[2, 3, 4]; // Трехмерный массив 2x3x4
        int [,,,] my4DArray = new int[2, 3, 4, 5]; // Четырехмерный массив 2x3x4x5. Обычно не применяется.
        
        // Ручное заполнение трехмерного массива
        
        int[,,] my3DArrayManual = new int[2, 3, 4] //Для примера
        {
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            },
            {
                {13, 14, 15, 16},
                {17, 18, 19, 20},
                {21, 22, 23, 24}
            }
        };
        
        
        
        // Заполнение трехмерного массива случайными числами от 1 до 100
        Random random = new Random();
        for (int i = 0; i < my3DArray.GetLength(0); i++) // Первая размерность
        {
            for (int j = 0; j < my3DArray.GetLength(1); j++) // Вторая размерность
            {
                for (int k = 0; k < my3DArray.GetLength(2); k++) // Третья размерность
                {
                    my3DArray[i, j, k] = random.Next(100);
                }
            }
        }
        
        Console.WriteLine("Выводим значение элемента трехмерного массива my3DArray[0, 2, 3]:");
        Console.WriteLine(my3DArray[0, 2, 3]);

        Console.WriteLine();
        Console.WriteLine("Выводим значения элементов трехмерного массива my3DArray:");
        
        for (int i = 0; i < my3DArray.GetLength(0); i++) // Первая размерность
        {
            for (int j = 0; j < my3DArray.GetLength(1); j++) // Вторая размерность
            {
                for (int k = 0; k < my3DArray.GetLength(2); k++) // Третья размерность
                {
                    Console.Write(my3DArray[i, j, k] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        
        //зубчатый трехмерный массив
        int[][][] jagged3DArray = new int[random.Next(3,6)][][]; // Зубчатый трехмерный массив
        
        
        
        
    }
}