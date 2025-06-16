namespace Episode016
{
    /*
     * Операторы отношений и операции сравнения в C#.
     * 
     */

/*
 *    == равно
 *    != не равно
 *    < меньше
 *    > больше
 *    <= меньше или равно
 *    >= больше или равно
 *    
 */

    internal class Program
    {
         static void Main(string[] args)
    {
            int a = 5;
            int b = 10;

            bool result = a == b;


            Console.WriteLine("A равна B?");
            Console.WriteLine(result);
            Console.WriteLine("A не равна B?");
            Console.WriteLine(a!=b);
            Console.WriteLine("A меньше B");
            Console.WriteLine(a < b);
            Console.WriteLine("A больше B");
            Console.WriteLine(a > b);
            Console.WriteLine("A меньше или равно B");
            Console.WriteLine(a <= b);
            Console.WriteLine("A больше или равно B");
            Console.WriteLine(a >= b);



        }
    }
}
