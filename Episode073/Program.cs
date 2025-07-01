namespace Episode073
/*
 * Что такое var
 * Неявно типизированные локальные  переменные
 */



{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = 10;
            var b = "Hello, World!";
            var a = new float[] { 1.0f, 2.0f, 3.0f };

            var i = new Dictionary<int, string>
            {
                { 1, "One" },
                { 2, "Two" },
                { 3, "Three" }
            };

            // Dictionary<int, string> i = new Dictionary<int, string> - пример явного указания типа

            // Работа с анонимными типами





            Console.WriteLine(t.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(a.GetType());
        }
    }
}
