namespace HomeWork004
{

    // Домашнее задание. Программа, которая будет подсчитывать количество четных и нечетных чисел в том диапозоне , который введет пользователь.
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int limit = 0;
            int evenCount = 0;
            int oddCount = 0;


            Console.WriteLine("Введите лимит для подсчета четных и нечетных чисел");
            if (!int.TryParse(Console.ReadLine(), out limit))
            {
                Console.WriteLine("Ошибка. Введено некорректное число!");
                return;
            }


            while (count < limit)
            {
                count++;
                if (count % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }

            }

            Console.WriteLine($"Количество четных чисел: {evenCount}");
            Console.WriteLine($"Количество нечетных чисел: {oddCount}");
        }
    }
}
