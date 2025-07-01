namespace HomeWork011

// Реализовать вывод массива с помошью рекурсии
// Найти суммму элементов массива с помошью рекурсии
// Найти сумму цифр числа с помошью рекурсии




{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Основные переменные
            int[] array = { 1, 2, 3, 4, 5 };
            int valueForSum = 125678;
            

            // Вывод элементов массива на консоль
            Console.Write($"Элеметы массива: ");
            PrintArray(array);
            Console.WriteLine();

            // Вывод суммы элементов массива на консоль
            Console.Write($"Сумма элементов массива: ");
            Console.WriteLine(SumArray(array));

            // Вывод суммы цифр числа на консоль
            Console.Write($"Сумма цифр числа {valueForSum}: ");
            Console.WriteLine(SumDigits(valueForSum));

        }
        // Метод для вывода массива на консоль с помошью рекурсии
        static void PrintArray(int[] array, int index = 0)
        {
            if (index < array.Length)
            {
                Console.Write(array[index] + " ");
                PrintArray(array, index + 1);
            }
        }

        // Метод для нахождения суммы элементов массива с помошью рекурсии
        static int SumArray(int[] array, int index = 0)
        {
            if (index >= array.Length)
            {
                return 0;
            }    
            
            return array[index] + SumArray(array, index + 1);
        }

        // Метод для нахождения суммы цифр числа с помошью рекурсии
        static int SumDigits(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            return number % 10 + SumDigits(number / 10);
        }
    }
}
