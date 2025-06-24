namespace Episode053;

/*
 * Что такое null
 */

class Program
{
    static void Main(string[] args)
    {
        // Запусти дебагер и посмотри на значения переменных. И все станет понятно.
        
        bool b;

        int a;

        double d;
        
        Random random;

        int[] myArray;
        // Создаем переменную, которая будет ссылаться на массив из 10 элементов типа int
        myArray = new int[10];
        // Разрываем ссылку на массив. Память, выделенная под массив, будет освобождена сборщиком мусора, когда посчитает нужным.
        myArray = null;
        
        MyClass myClass;
        
        MyStruct myStruct;
    }

    class MyClass
    {
        
    }
    
    struct MyStruct
    {
        
    }
}