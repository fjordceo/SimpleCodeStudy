namespace HomeWork003
{   // Простой калькулятор, который выполняет сложение, вычитание, умножение и деление двух чисел
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue;
            double secondValue;
            char operation;
            double result = 0;
            ConsoleKey userKey;

            // Ввод данных от пользователя


            while (true)
            {
                Console.Clear();

                Console.WriteLine("Введите первое число:");
                if (!double.TryParse(Console.ReadLine(), out firstValue))
                {
                    Console.WriteLine("Ошибка. Введено некорректное число!");
                    return;
                }
                Console.WriteLine("Введите второе число");
                if (!double.TryParse(Console.ReadLine(), out secondValue))
                {
                    Console.WriteLine("Ошибка. Введено некорректное число!");
                    return;
                }
                Console.WriteLine("Что вы хотите сделать с этими числами?");
                if (!char.TryParse(Console.ReadLine(), out operation) || (operation != '+' && operation != '-' && operation != '*' && operation != '/'))
                {
                    Console.WriteLine("Ошибка. Введена некорректная операция!");
                    return;
                }




                // Реализация калькулятора с использованием if-else
                if (operation == '+')
                {
                    result = firstValue + secondValue;
                    Console.WriteLine($"Сумма чисел = {result}");
                }
                else if (operation == '-')
                {
                    result = firstValue - secondValue;
                    Console.WriteLine($"Разница чисел = {result}");
                }
                else if (operation == '*')
                {
                    result = firstValue * secondValue;
                    Console.WriteLine($"Произведение чисел = {result}");
                }
                else if (operation == '/')
                {
                    if (secondValue == 0)
                    {
                        Console.WriteLine("Ошибка. Деление на ноль невозможно!");
                        return;
                    }
                    result = firstValue / secondValue;
                    Console.WriteLine($"Результат деления чисел = {result}");
                }

                Console.ReadKey();
                Console.WriteLine("A теперь давай сделаем тоже самое, но толлько через Switch");
                Console.ReadKey();
                Console.WriteLine("Я не буду просить тебя снова ввести числа... А просто посчитаю");
                Console.ReadKey();
                Console.WriteLine("Только нажми клавишу с действием которое хочешь сделать");
                userKey = Console.ReadKey().Key;


                // Реализация калькулятора с использованием switch
                switch (userKey)
                {
                    case ConsoleKey.OemPlus:
                    case ConsoleKey.Add:
                        result = firstValue + secondValue;
                        Console.WriteLine($"\nСумма чисел = {result}");
                        break;

                    case ConsoleKey.OemMinus:
                    case ConsoleKey.Subtract:
                        result = firstValue - secondValue;
                        Console.WriteLine($"\nРазница чисел = {result}");
                        break;
                    case ConsoleKey.Multiply:
                        result = firstValue * secondValue;
                        Console.WriteLine($"\nПроизведение чисел = {result}");
                        break;
                    case ConsoleKey.Oem2:
                    case ConsoleKey.Divide:
                        if (secondValue == 0)
                        {
                            Console.WriteLine("\nОшибка. Деление на ноль невозможно!");
                            return;
                        }
                        result = firstValue / secondValue;
                        Console.WriteLine($"\nРезультат деления чисел = {result}");
                        break;

                        
                }
                Console.ReadKey();
            }

        }
    }
}
