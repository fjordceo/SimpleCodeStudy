namespace Episode022

/*
 * Цикл while в С#. Цикл с предусловием.
 * 
 * Всего пройдено 21 урок. Время обучения: 04:16:28
 * 
 */

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int limit = int.Parse(Console.ReadLine()); // Чтение предела из ввода пользователя
            // Цикл while выполняется, пока условие истинно
            while (count < limit)
            {
                count ++;   
                Console.WriteLine(count);
            }
        }
    }
}

// Домашнее задание. Программа которая будет подсчитывать количество четных и нечетных чисел в том диапозоне , который введет пользователь.