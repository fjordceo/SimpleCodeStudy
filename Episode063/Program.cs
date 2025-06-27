using System.ComponentModel;

namespace Episode063
/*
 * Ключевое слово params
 * Рализует возможность передачи переменного количества аргументов в метод
 */


{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int result = Sum(a, b);
            int result_1 = Sum (a, b, 30);
            int resultParams = SumParams(1,2,3,4,5,6,7,8,9,10,11,15);

            Console.WriteLine($"Результат метода Sum с двумя параметрами {result}");
            Console.WriteLine($"Результат метода Sum с тремя параметрами {result_1}");
            Console.WriteLine($"Результат метода SumParams {resultParams}");
        }

        static int Sum(int a, int b)
        {
             return a + b;
        }

        // Перегрузка метода Sum
        static int Sum (int a, int b, int c)
        {
            return a + b + c;
        }

        static int SumParams(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
