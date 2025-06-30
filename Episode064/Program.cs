namespace Episode064
/*
 *  Необязательные параметры методов
 *  Именованные параметры (аргументы)
 */

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            int result = Sum(10, 20, true);
            int result1 = Sum(b: 20, a: 10, enableLogging: true);  // Использование именованных параметров
            int result2 = Sum(a: a, b:b, enableLogging: true); // В именованные параметры можно передавать переменные

            Console.WriteLine(result);
            Console.WriteLine(result1);
        }

        static int Sum(int a, int b, bool enableLogging = false)
        {
            int result = a + b;
            if (enableLogging)
            {
                Console.WriteLine("Значение переменной А = " + a);
                Console.WriteLine("Значение переменной B = " + b);
                Console.WriteLine("Результат сложения = " + result);
            }
            return result;

        }
    }
}
