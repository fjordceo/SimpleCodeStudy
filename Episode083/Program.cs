namespace Episode083
/*
 * Ключевое слово static в C# используется для объявления статических членов класса.
 * 
 * Статистические поля класса принадлежат самому классу, а не его экземплярам.
 */

{
    class MyClass
    {
        public int a;
        private static int b; // Статическое поле класса
        public void SetB(int b)
        {
            MyClass.b = b;
        }
        public void PrintB()
        {
            Console.WriteLine(b);
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            

            MyClass myClass1 = new MyClass();
            myClass1.a = 10; // Установка значения поля a для первого экземпляра
            myClass1.SetB(100);
            
            MyClass myClass2 = new MyClass();
            myClass2.a = 20; // Установка значения поля a для второго экземпляра
            myClass2.PrintB();
        }
    }
}
