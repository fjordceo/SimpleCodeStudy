namespace Episode028
    
    /*
     * Ключевое слово Continue
     */


{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 2) // Пропускаем число 2
                {
                    continue; // Переход к следующей итерации цикла
                }

                Console.WriteLine(i); // Вывод нечетных чисел
            }
        }
    }
}
