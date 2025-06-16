namespace Episode025;
/*
 *  Цикл for. Прокаченный while 
 */



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество циклов");
        int limit = int.Parse(Console.ReadLine());
        
        for (int i = 0; i <= limit; i++) // переменная i существует только в рамках данного цикла
        {
            Console.WriteLine(i);
        }
    }
}