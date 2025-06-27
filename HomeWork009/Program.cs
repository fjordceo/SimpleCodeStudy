namespace HomeWork009


/*
 * Написать методы для добавления элемента в начало и конец массива по указанному индексу.
 */

{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Инициализация переменных
            int[] myArray = new int[5] { 2, 2, 3, 4, 5 };
            int elementToAdd;
            int elementToStart;
            int elementToEnd;
            int index;


            DisplayArray(myArray);

            // Запрос на добавление элемента по индексу
            Console.Write("Введите индекс, по которому нужно добавить элемент: ");
            if (!int.TryParse(Console.ReadLine(), out index))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                return;
            }
            if (index < 0 || index > myArray.Length)
            {
                Console.WriteLine("Некорректный индекс. Индекс должен быть в пределах от 0 до длины массива.");
                return;
            }
            Console.Write("Введите элемент, который нужно добавить: ");
            if (!int.TryParse(Console.ReadLine(), out elementToAdd))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                return;
            }

            AddElementByIndex(ref myArray, elementToAdd, index);
            DisplayArray(myArray);

            // Запрос элемента для добавления в начало массива
            Console.Write("Введите элемент который нужно добавить в начало массива: ");
            if (!int.TryParse(Console.ReadLine(), out elementToStart))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                return;
            }

            AddElementToStart(ref myArray, elementToStart);
            DisplayArray(myArray);

            // Запрос элемента для добавления в конец массива
            Console.Write("Введите элемент, который нужно добавить в конец массива: ");
            if (!int.TryParse(Console.ReadLine(), out elementToEnd))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                return;
            }

            AddElementToEnd(ref myArray, elementToEnd);
            DisplayArray(myArray);

        }

        // Метод для добавления элемента по указанному индексу
        static void AddElementByIndex<T>(ref T[] arrayToAdd, T element, int index)
        {
            T[] newArray = new T[arrayToAdd.Length + 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = arrayToAdd[i];
            }

            newArray[index] = element;
            for (int i = index; i < arrayToAdd.Length; i++)
            {
                newArray[i + 1] = arrayToAdd[i];
            }
            arrayToAdd = newArray;

        }

        // Метод для добавления элемента в начало массива
        static void AddElementToStart<T>(ref T[] myArray, T elementToStart)
        {

            T[] newArray = new T[myArray.Length + 1];

            newArray[0] = elementToStart;

            for (int i = 0; i < myArray.Length; i++)
            {
                newArray[i + 1] = myArray[i];
            }
            myArray = newArray;

        }

        // Метод для добавления элемента в конец массива
        static void AddElementToEnd<T>(ref T[] arrayToAdd, T elementToEnd)

        {
            T[] newArray = new T[arrayToAdd.Length + 1];

            newArray[newArray.Length - 1] = elementToEnd;

            for (int i = 0; i < arrayToAdd.Length; i++)
            {
                newArray[i] = arrayToAdd[i];
            }
            arrayToAdd = newArray;
        }
        
        // Метод для отображения нового массива
        static void DisplayArray<T>(T[] myArray)
        {
            Console.WriteLine($"Массив состоит из {myArray.Length} элементов");
            Console.Write("Элементы массива: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]}\t");
            }
            Console.WriteLine();
        }

        
    }
}
