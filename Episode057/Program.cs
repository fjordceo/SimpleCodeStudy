namespace Episode057;

/*
 * Ключевое слово ref
 * Передача аргументов по ссылке
 */

class Program
{
    // Так делать не надо, но для примера сойдет
    static void Foo(ref int a, ref int b, ref int c)
    {
        a = -5;
        b = -10;
        c = -15;
    }
    
    static void Foo1 (ref MyStruct myStruct)
    {
        myStruct.a = -5;
        myStruct.b = -10.5;
        myStruct.c = -15.5f;
    }

    struct MyStruct
    {
        public int a;
        public double b;
        public float c;
    }
    
    static void Bar(ref int [] arr)
    {
        arr = new int [10];
    }

    
    static void Main(string[] args)
    {
        int a = 2;
        int b = 3;
        int c = 4;
        
        Foo(ref a, ref b, ref c);
        
        Console.WriteLine($"Переменная равна {a}");
        Console.WriteLine($"Переменная равна {b}");
        Console.WriteLine($"Переменная равна {c}");
        
        MyStruct myStruct = new MyStruct();
        
        Foo1(ref myStruct);;
        Console.WriteLine($"Переменная myStruct.a равна {myStruct.a}");
        Console.WriteLine($"Переменная myStruct.b равна {myStruct.b}");
        Console.WriteLine($"Переменная myStruct.c равна {myStruct.c}");

        
        int[] myArray = { 1, 2, 3 };
        Bar(ref myArray);
        Console.WriteLine($"Длинна массива {myArray.Length}");
    } 
}