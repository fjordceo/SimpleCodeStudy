namespace Episode074
/*
 * enum (перечисление)
 */

{
    internal class Program
    { 
        enum DayOfWeek : byte // Можно использовать byte, sbyte, short, ushort, int, uint, long, ulong
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }




        static void Main(string[] args)
        {
            // Пример использования перечисления
            //while (true)
            //{
            //    ConsoleKey key = Console.ReadKey(true).Key;

            //    int keyValue = (int)key;

            //    Console.WriteLine($"\tEnum {key}\tKey Code: {keyValue}");

            //    if (key == ConsoleKey.Enter)
            //    {
            //        Console.WriteLine("Вы нажали Enter!");

            //    }
            //}

            DayOfWeek dayOfWeek = DayOfWeek.Monday;

            Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));
            Console.WriteLine(dayOfWeek);
            Console.WriteLine((int)dayOfWeek);
            Console.WriteLine((DayOfWeek)3); // Приведение к перечислению
            
          



        }
    }
}
