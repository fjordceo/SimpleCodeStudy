namespace HomeWork005;

// Программа выводящая на экран консоли треугольники, состоящие из #

class Program
{
    static void Main(string[] args)
    {
        char sharp = '#';
        char space = ' ';
        Console.WriteLine("Введите ширину треугольника");
        int height = int.Parse(Console.ReadLine());

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(sharp);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        
        for (int i = height; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(sharp);
            }
            Console.WriteLine();
        }
        
        Console.WriteLine();

        for (int i = 1; i < height; i++)
        {
            for (int j = 0; j < height - i; j++)
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

        for (int i = height; i > 0; i--)
        {
            for (int j = 0; j < height - i; j++)
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