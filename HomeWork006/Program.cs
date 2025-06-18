namespace HomeWork006;
/*
 * Домашние задания
 * 1. Заполнить массив с клавиатуры
 * 2. Вывести массив в обратном порядке
 * 3. Найти сумму четных чисел в массиве
 * 4. Найти наименьшее число в массиве
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
            Console.Write($"Введите элемент массива с индексом {i}\t");
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("А теперь выведем основные показатели данного массива. Нажмите любую клавишу");
        Console.ReadKey();

        Console.Write("Массив в обратном порядке\t");
        for (int i = myArray.Length - 1; i >= 0; i--)
        {
            Console.Write(myArray[i]);
            Console.Write(" ");
        }
        Console.WriteLine();

        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] % 2 == 0)
            {
                sum += myArray[i];
            }
        }

        Console.WriteLine($"Сумма четных элементов массива:\t {sum}");
        
       int min = myArray[0];
        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] < min)
            {
                min = myArray[i];
            }
        }
        
        Console.WriteLine($"Наименьший элемент массива:\t {min}");
    }
}