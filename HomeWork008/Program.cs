using System.Security.Cryptography;

namespace HomeWork008

 /*
 * Написать метод Resize, изменяющий количество элементов в массиве(метод дожен иметь возможность увеличивать и уменьшать количество элементов в массиве).
 */

{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            // Инициализация переменных
            int[] myArray = new int[5] { 2, 2, 3, 4, 5 };
            int newArraySize;


            // Вывод информации о текущем массиве
            Console.WriteLine($"Исходный массив имеет {myArray.Length} элементов");
            Console.Write("Элементы массива: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]}\t");
            }
            Console.WriteLine();

            // Запрос нового размера массива у пользователя
            Console.Write("Введите новое количество элементов в массиве:");
            if (!int.TryParse(Console.ReadLine(), out newArraySize))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                return;
            }

            // Проверка, нужно ли изменять размер массива
            if (newArraySize == myArray.Length)
            {
                Console.WriteLine("Размер массива не изменился! И не нужно нам никакой метод вызывать");
                return;
            }
          

            Resize(ref myArray, newArraySize);

            // Вывод информации о новом массиве
            Console.WriteLine($"Новый массив имеет {myArray.Length} элементов");
            Console.Write("Элементы массива: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]}\t");
            }
            Console.WriteLine();
        }

        // Метод для изменения размера массива
        static void Resize<T>(ref T[] arrayForResize, int newArraySize)
        {
            if (newArraySize < 0)
            {
                Console.WriteLine("Размер массива не может быть отрицательным!!!");
                return;
            }

            T[] newArray = new T[newArraySize];
            for (int i = 0; i < arrayForResize.Length &&  i<newArray.Length; i++)
                  newArray[i] = arrayForResize[i];
          
            arrayForResize = newArray;
            
        }
    }
}
