namespace Episode085
/*
 * Ключевое слово static в C#
 * 
 * Статистические конструкторы класса выполняются один раз при первом обращении к статическому члену класса или при создании первого экземпляра класса.
 */
{

    class MyClass
    {
        static MyClass()
        {
            Console.WriteLine("Static constructor called.");
        }
        public MyClass()
        {
            Console.WriteLine("Instance constructor called.");
        }
        public static void StaticMethod()
        {
            Console.WriteLine("Static method called.");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
