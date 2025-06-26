using System.Security.Cryptography;

namespace HomeWork008

 /*Домашнее задание:
 * 1. Написать метод Resize, изменяющий количество элементов в массиве(метод дожен иметь возможность
 * увеличивать и уменьшать количество элементов в массиве).
 */

{
    internal class Program
    {

        static void Resize(ref int[] myArray, int newArraySize)
        {
                myArray = new int[newArraySize];  
        }

        static void Main(string[] args)
        {
            int[] myArray = new int[5] { 2, 2, 3, 4, 5 };
            int newArraySize;

            Console.WriteLine($"Исходный массив имеет {myArray.Length} элементов");
            Console.Write("Введите новое количество элементов в массиве:");

           if (!int.TryParse(Console.ReadLine(), out newArraySize))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                return;
            }
           
           if (newArraySize == myArray.Length)
            {
                Console.WriteLine("Размер массива не изменился! И не нужно нам никакой метод вызывать");
                return;
            }
           else if (newArraySize < 0)
            {
                Console.WriteLine("Размер массива не может быть отрицательным!!!");
                return;
            }

            Resize(ref myArray, newArraySize);
            Console.WriteLine($"Массив теперь имеет {myArray.Length} элементов");
        }
    }
}
