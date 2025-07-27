namespace Episode015
{
    /*
     * Инкремент и Декремент в C#. Постфиксный и префиксный метод записи.
     * 
     */


    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            a++; // Инкремент (постфиксный)
            ++a; // Инкремент (префиксный)

            b--; // Декремент (постфиксный)
            --b; // Декремент (префиксный)

            // Префиксный инкремент обладает наивысшей приоритетностью
            Console.WriteLine(a);
            Console.WriteLine(++a);
           

            Console.WriteLine(a);
            Console.WriteLine(a++);


            Console.ReadKey();
        }
    }
}
