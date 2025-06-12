namespace HomeWork002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;

            Console.WriteLine("Домашнее задание. Проверка числа на четность");
            Console.Write("Введите целое число: ");
            if (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Ошибка: введено не целое число. Я же просил!");
                return;
            }
            if (value % 2 == 0)
            {
                Console.WriteLine($"Число {value} является четным.");
            }
            else
            {
                Console.WriteLine($"Число {value} является нечетным.");
            }

            Console.ReadKey();

        }
    }
}
