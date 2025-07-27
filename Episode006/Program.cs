namespace Episode006;

/*
 * Объявление переменных. Инициализация и присвоение значений переменным
 */

class Program
{
    static void Main(string[] args)
    {
        int a;
        a = 10;
        int b = 20; // Инициализация - это присвоение значения переменной при объявлении (первый раз).
        b = 25; // Присвоение значения - это изменение значения переменной после инициализации.

        int c, d, e;
        c = d = e = 30; 

        bool variable = false;
        bool variable2 = true;

        char w = '@';
        string name = "Ivan";
        
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c+d+e);
        Console.WriteLine(w);
        Console.WriteLine(name);
        Console.WriteLine(variable);
        Console.WriteLine(variable2);
    }
}