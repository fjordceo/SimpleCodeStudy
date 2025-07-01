namespace Episode070
/*
 * Явное и неявное приведение (преобразование) типов 
 * сужающее и расширяющее преобразование типов
 */





{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double d = a; // Неявное приведение int к double (implicit conversion)
            float b = a; // Неявное приведение int к float (implicit conversion) (расширяющее преобразование типов)
            b = (float)d; // Явное приведение double к float (explicit conversion) (сужающее преобразование типов)

            Foo(a); // Неявное приведение int к float
            Foo((float)d); // Явное приведение double к float

            int firstValue = 5;
            float secondValue = 10.5f;
            int result = firstValue + (int)secondValue; 
            float resultFloat = firstValue + secondValue; 
            Console.WriteLine(result);
            Console.WriteLine(resultFloat);




        }

        static void Foo (float value)
        {
            Console.WriteLine(value);
        }



    }
}
