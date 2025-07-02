namespace Episode084
/*
 * Ключевое слово static в C#
 * 
 * Статистические методы класса принадлежат самому классу, а не его экземплярам.
 * 
 * Статистические свойства класса также принадлежат самому классу, а не его экземплярам.
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

        public static void Foo()
        {
            // Пример статического метода
            Console.WriteLine("Запущен метод Foo");
            b= 42; // Изменение статического поля класса
        }

        public void Bar()
        {
            Console.WriteLine("Запущен метод Bar");
            b = 100; // Изменение статического поля класса из нестатического метода
            Foo();
        }


    }

    class Count
    {
        public Count()
        {
            counter++;
        }

        private static int counter;

        public static int Counter
        {
            get { return counter; }
            private set { counter = value; }
        }

        public static int GetCounter()
        {
            return counter;
        }

        public int GetObjectsCount()
        {
            return counter;
        }
    }








    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass.Foo(); // Вызов статического метода класса MyClass

            


            MyClass myClass1 = new MyClass();
            myClass1.a = 10; // Установка значения поля a для первого экземпляра
            myClass1.SetB(100);
            myClass1.Bar(); // Вызов нестатического метода, который изменяет статическое поле


            MyClass myClass2 = new MyClass();
            myClass2.a = 20; // Установка значения поля a для второго экземпляра
            myClass2.PrintB();


            Console.WriteLine(); // Использование статического метода
            Array.Sort(new int[] { 3, 1, 2 }); // Вызов статического метода Sort из класса Array



            
            Count count1 = new Count();
            Count count2 = new Count();
            Count count3 = new Count();

            ;

            Console.WriteLine(count3.GetObjectsCount());


            Console.WriteLine($"Создано экземпляров класса: {Count.Counter}");
            Console.WriteLine($"Создано экземпляров класса: {Count.GetCounter()}");
        }
    }
}