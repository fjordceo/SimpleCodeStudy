namespace Episode020
{   /*
     * Условный оператор switch в C#. Конструкция switch case.
     * 
     *
     * 
     * Всего пройдено 16 уроков. Время обучения: 03:41:06
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберете вариант развития событий! от 1 до 3");
            int a = int.Parse(Console.ReadLine());


            switch (a)
            { 
                case 1:
                        Console.WriteLine("Вы выбрали первый вариант");
                        break;
                case 2:
                        Console.WriteLine("Вы выбрали второй вариант");
                        break;
                case 3:
                    {   // Можно использовать фигурные скобки для группировки кода
                        Console.WriteLine("Вы выбрали третий вариант");
                    }
                    
                        break;
                default:
                        Console.WriteLine("Вы не выбрали ни один из вариантов");
                        break;
            }

            // Так же мы можем использовать строковые литералы для switch case
            
            
            Console.WriteLine("Выберите вариант ответа: 'yes' или 'no'");
            string userInput = Console.ReadLine();

            
            switch (userInput)
            {
                case "yes":
                    Console.WriteLine("Вы ответили 'да'");
                    break;
                case "no":
                    Console.WriteLine("Вы ответили 'нет'");
                    break;
                default:
                    Console.WriteLine("Вы ввели что-то другое");
                    break;
            }


            Console.WriteLine("Нажмите клавишу A,B,C");
            ConsoleKey userKey = Console.ReadKey().Key;
            
            switch (userKey)
            {
                case ConsoleKey.A:
                    Console.WriteLine("Вы нажали клавишу A");
                    break;
                case ConsoleKey.B:
                    Console.WriteLine("Вы нажали клавишу B");
                    break;
                case ConsoleKey.C:
                    Console.WriteLine("Вы нажали клавишу C");
                    break;
                default:
                    Console.WriteLine("Вы нажали другую клавишу");
                    break;
            }





            // Домашнее задание: Написать простой калькулятор который будет выполнять операции сложения, вычитания, умножения и деления
            // в зависимости от введенного пользователем знака операции (+, -, *, /).





        }
    }
}
