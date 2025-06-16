namespace HomeWork004
{

    // Домашнее задание. Программа, которая будет подсчитывать количество четных и нечетных чисел. Диапазон вводит пользователь.
    // Добавить сумму нечетных и сумму четных чисел
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int limit;
            int evenCount = 0;
            int oddCount = 0;
            int sumEven = 0;
            int sumOdd = 0;

            Console.WriteLine("Добро пожаловать в программу которая считает количество четных и нечетных чисел выбранного диапазона");
            Console.WriteLine("Введите число с которого мы начнем отчет");
            if (!int.TryParse(Console.ReadLine(), out count))
            {
                Console.WriteLine("Ошибка. Введено некорректное число!");
                return;
            }
            
            
            Console.WriteLine("Введите лимит для подсчета четных и нечетных чисел");
            if (!int.TryParse(Console.ReadLine(), out limit))
            {
                Console.WriteLine("Ошибка. Введено некорректное число!");
                return;
            }


            while (count <= limit)
            {
                
                if (count % 2 == 0)
                {
                    evenCount++;
                    sumEven += count;
                }
                else
                {
                    oddCount++;
                    sumOdd += count;
                }
                
                count++;
            }

            Console.WriteLine($"Количество четных чисел: {evenCount}");
            Console.WriteLine($"Количество нечетных чисел: {oddCount}");
            Console.WriteLine($"Сумма четных чисел: {sumEven}");
            Console.WriteLine($"Сумма нечетных чисел: {sumOdd}");
            
        }
    }
}
