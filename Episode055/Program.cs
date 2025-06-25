namespace Episode055

/*
 *  Оператор присваивания объединения со значением Null (??=)
 */

{
    internal class Program
    {
        static int [] GetArrey() // Метод возвращающий null в массиве
        {
            int[] myArray = null;
            return myArray;
        }


        static void Main(string[] args)
        {
            string str = null;

            str ??= "Default Value"; // Присваивание значения по умолчанию, если str равно null

            Console.WriteLine($"Количество символов в строке {str.Length}");

            int[] myArray = GetArrey();

            myArray ??= new int[0];  // Присваивание пустого массива, если myArray равно null

            Console.WriteLine($"Количество элементов в массиве {myArray.Length}");


        }
    }
}
