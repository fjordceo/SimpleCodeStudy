namespace HomeWork010

    /*
     * 3. Написать методы для удаления первого элемента масива, последнего элемента массива и элемента по указанному индексу.
     */




{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] myArray = new int[] { 2, 2, 3, 16,7,1,8,7,2,4, 5 };
            int indexToRemove;

            Console.WriteLine($"У нас есть массив, состоящий из {myArray.Length} элементов");
            Console.Write("Элементы массива: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]}\t");
            }
            Console.WriteLine();

            Console.Write("Удалим первый элемент массива? Y/N: ");
            if (Console.ReadLine()?.ToUpper() == "Y")
            {
                RemoveFirstElement(ref myArray);
                Console.WriteLine($"Массив теперь состоит из {myArray.Length} элементов");
                Console.Write("Элементы массива: ");
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write($"{myArray[i]}\t");
                }
                Console.WriteLine();
            }

            Console.Write("Удалим последний элемент массива? Y/N: ");
            if (Console.ReadLine()?.ToUpper() == "Y")
            {
                RemoveLastElement(ref myArray);
                Console.WriteLine($"Массив теперь состоит из {myArray.Length} элементов");
                Console.Write("Элементы массива: ");
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write($"{myArray[i]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("А теперь давай удалим элемент из оставшегося массива номер которого ты введешь");
            indexToRemove = int.Parse(Console.ReadLine() ?? "0");

            RemoveElementByIndex(ref myArray, indexToRemove);

            static void RemoveFirstElement(ref int[] myArray)
            {
                int[] newArray = new int [myArray.Length - 1];

                for (int i = 1; i < myArray.Length; i++)
                {
                    newArray[i - 1] = myArray[i];
                }

                myArray = newArray;
            }

            static void RemoveLastElement(ref int[] myArray)
            {
                int[] newArray = new int [myArray.Length - 1];
                for (int i = 0; i < myArray.Length - 1; i++)
                {
                    newArray[i] = myArray[i];
                }
                myArray = newArray;
            }


            static void RemoveElementByIndex(ref int[] myArray, int index)
            {
                if (index < 0 || index >= myArray.Length)
                {
                    Console.WriteLine("Индекс вне диапазона массива!");
                    return;
                }
                int[] newArray = new int[myArray.Length - 1];
               
                for (int i = 0, j = 0; i < myArray.Length; i++)
                {
                    if (i != index)
                    {
                        newArray[j++] = myArray[i];
                    }
                }

                myArray = newArray;
                Console.WriteLine($"Элемент с индексом {index} удален. Массив теперь состоит из {myArray.Length} элементов.");
                Console.Write("Элементы массива: ");
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write($"{myArray[i]}\t");
                }
            }






        }
    }
}
