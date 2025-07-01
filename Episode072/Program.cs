using System.Data;

namespace Episode072
    /*
     * Null-совместимые значимые типы (Nullable types)
     */


{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ссылочные типы могут быть null
            string str = null; // Строка может быть null


            // Значимые типы не могут быть null, но можно использовать Nullable<T> или ? для создания null-совместимых типов
           DateTime? date = null; // Nullable<DateTime> или DateTime? позволяет хранить null

            int? a = null; // Ошибка компиляции, int не может быть null

            Console.WriteLine(a == null); // Проверка на null для Nullable<int>

            Console.WriteLine(a.HasValue); // Проверка на наличие значения в Nullable<int>

            Console.WriteLine(a.GetValueOrDefault()); // Получение значения или 0, если значение null

            Console.WriteLine(a.GetValueOrDefault(3)); // Получение значения или 3, если значение null

            Console.WriteLine(a ?? 55); //  Использование оператора ?? для получения значения или 55, если значение null

            //Console.WriteLine(a.Value); // Получение значения, если значение не null, иначе выбросит исключение InvalidOperationException






        }
    }
}
