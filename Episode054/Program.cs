namespace Episode054;
/*
 *  оператор ?? (null-объединение)
 *  Синтаксический сахар для проверки на null
 */

class Program
{
    static void Main(string[] args)
    {
        string name = "Test";
        //name = null; // Раскомментируй эту строку, чтобы проверить работу оператора ?? (null-объединение)

        // Стандартная проверка на null
        if (name == null)
        {
            Console.WriteLine("Стандартная проверка: Нет данных");
        }
        else
        {
            Console.WriteLine($"Стандартная провека: {name}");
        }

        // Синтаксический сахар для проверки на null
        Console.WriteLine($"Проверка с помощью null объединения: {name ?? "Нет данных"}");

    }
}