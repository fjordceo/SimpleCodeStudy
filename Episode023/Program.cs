namespace Episode023

/*
* Цикл do while в С#
* 
*/

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int limit = 500000000;

            do
            {
                count++;
                Console.WriteLine(count);
            } while (count < limit);
            
            
            
            
            
            
            Console.WriteLine("Hello, World!");
        }
    }
}
