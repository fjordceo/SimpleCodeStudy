namespace Episode071
/*
 * "Ядерный Ганди" и арифметическое переполнение
 */



{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte aggression = 1;

            byte democracyModifier = 2;

            aggression = (byte)(aggression - democracyModifier);
            //aggression = checked((byte)(aggression - democracyModifier));  - Проверка на переполнение
            // checked
            // {}
            // unchecked - отключение проверки на переполнение, работает если в проекте включена проверка на переполнение


            Console.WriteLine($"Агрессивность Ганди: {aggression}");


            int a = int.MaxValue; // 2147483647
            a = a + 1; // Переполнение через верхнюю границу

            int b = int.MinValue; // -2147483648
            b = b - 1; // Переполнение через нижнюю границу

            Console.WriteLine($"Значение А: {a}, значение B: {b}");

        }
    }
}
