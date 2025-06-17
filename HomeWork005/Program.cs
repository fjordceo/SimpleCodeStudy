namespace HomeWork005;

// Программа выводящая на экран консоли треугольники, состоящие из #

class Program
{
    static void Main(string[] args)
    {
        char sharp = '#';
        char space = ' ';

        for (int i = 1; i < 10; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(sharp);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        
        for (int i = 10; i > 0; i--)
        {
            for (int j = 1; j < i; j++)
            {
                Console.Write(sharp);
            }
            Console.WriteLine();
        }
        
        Console.WriteLine();

        for (int i = 1; i < 10; i++)
        {
            for (int j = 0; j < 10 - i; j++)
            {
                Console.Write(space);
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write(sharp);
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 10; i > 0; i--)
        {
            for (int j = 0; j < 10 - i; j++)
            {
                Console.Write(space);
            }
            for (int j = 0; j < i; j++)
            {
                Console.Write(sharp);
            }
            Console.WriteLine();
        }








    }
}