namespace HomeWork006;
/*
 * Домашние задания
 * 1. Заполнить массив с клавиатуры
 * 2. Вывести массив в обратном порядке
 * 3. Найти сумму четных чисел в массиве
 * 4. Найти наименьшее число в массиве
 * Без валидации. Цель урока не в этом
 */

class Program
{
    static void Main(string[] args)
    {
        int quantity;
        int sum = 0;

        Console.Write("Пожалуйста, введите количество элементов массива\t");
        quantity = int.Parse(Console.ReadLine());
        
        int[] myArray = new int[quantity];
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"\nВведите элемент массива с индексом {i}\t");
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nА теперь выведем основные показатели данного массива. Нажмите любую клавишу");
        Console.ReadKey();

        // Вывод массива в обратном порядке
        Console.Write("\nМассив в обратном порядке\t");
        for (int i = myArray.Length - 1; i >= 0; i--)
        {
            Console.Write(myArray[i]);
            Console.Write(" ");
        }
        Console.WriteLine();

        // Подсчет суммы четных значений массива
        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] % 2 == 0)
            {
                sum += myArray[i];
            }
        }

        Console.WriteLine($"\nСумма четных элементов массива:\t {sum}");
        
        // Определение минимального значения в массиве
       int min = myArray[0];
        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] < min)
            {
                min = myArray[i];
            }
        }
        
        Console.WriteLine($"\nНаименьший элемент массива:\t {min}");
    }
}