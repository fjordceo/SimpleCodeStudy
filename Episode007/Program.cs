namespace Episode007;

/*
 * Ввод данных в консоль
 */

class Program
{
    static void Main(string[] args)
    {
        string? name;
        Console.WriteLine("Ой а как тебя зовут?");
        name = Console.ReadLine();
        Console.WriteLine("Привет, " + name + "!!! Как у тебя дела?"); // конкатенация 
        
    }
}