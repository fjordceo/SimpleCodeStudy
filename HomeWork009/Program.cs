namespace HomeWork009


/*
 * Написать методы для добавления элемента в начало и конец массива по указанному индексу.
 */



{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] myArray = new int[5] { 2, 2, 3, 4, 5 };
            int newArraySize;
            int elementToStart;
            int elementToEnd;

            Console.WriteLine($"Исходный массив содержит {myArray.Length} элементов");
            Console.Write("Элементы массива: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]}\t");
            }
            Console.WriteLine();

            Console.Write("Введите элемент который нужно добавить в начало массива: ");
            if (!int.TryParse(Console.ReadLine(), out elementToStart))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                return;
            }

            AddElementToStart(ref myArray, elementToStart);

            Console.WriteLine($"Массив теперь содержит {myArray.Length} элементов");
            Console.Write("Элементы массива: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]}\t");
            }
            Console.WriteLine();

            Console.Write("Введите элемент, который нужно добавить в конец массива: ");
            if (!int.TryParse(Console.ReadLine(), out elementToEnd))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                return;
            }

            AddElementToEnd(ref myArray, elementToEnd);
            Console.WriteLine($"Массив теперь содержит {myArray.Length} элементов");
            Console.Write("Элементы массива: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]}\t");
            }
            Console.WriteLine();


        }
        static void AddElementToStart(ref int[] myArray, int elementToStart)
        {
          
           int[] newArray = new int[myArray.Length + 1];

           newArray[0] = elementToStart;

           for (int i = 0; i < myArray.Length; i++)
            {
                newArray[i+1] = myArray[i];
            }
           myArray = newArray;

        }

        static void AddElementToEnd(ref int[] myArray, int elementToEnd)

        {
            int[] newArray = new int[myArray.Length + 1];

            newArray[newArray.Length-1] = elementToEnd;

            for (int i = 0; i < myArray.Length; i++)
            {
                newArray[i] = myArray[i];
            }
            myArray = newArray;
        }

        





















    }
}
