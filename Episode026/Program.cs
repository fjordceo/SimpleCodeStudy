namespace Episode026;
/*
 * Особенности цикла For. Работа с несколькими переменными
 * Цикл For в обратном порядке
 * Несколько условий для цикла For
 */

class Program
{
    static void Main(string[] args)
    {
       //Пример цикла без параметров
        for (;;)
        {
            Console.WriteLine("For is working");
            System.Threading.Thread.Sleep(300);
            break;
        }
        
        //Пример цикла с несколькими условиями с одной переменной
        int i1 = 0;
        for (; i1 < 3; i1++)
        {
            Console.WriteLine("For 1: " + i1);
        }

        for (; i1 < 5; i1++)
        {
            Console.WriteLine("For 2: " + i1);
        }

        for (int j = 0; j < 7;)
        {
            Console.WriteLine(j);
            j++;
        }
        
        //Несколько переменных, несколько условий
        for (int a=0, b=0; a<10 || b<30; a++, b+=2)
        {
            Console.WriteLine("a =" + a + " b = " + b);
        }
        
        //Цикл в обратном порядке
        for (int c = 10; c >= 0; c--)
        {
            Console.WriteLine(c);
        }

    }
}