namespace Episode018
{   /*
     * Логические операторы в C#. Логические операторы AND, OR, NOT.
     * 
     *  && - логическое И (AND)
     *  || - логическое ИЛИ (OR)
     *  & - логическое И (AND) с побитовым сравнением
     *  | - логическое ИЛИ (OR) с побитовым сравнением
     *  ! - логическое НЕ (NOT)
     *
     * 
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            int fanSpeed = 0;
            bool isInfected = false;
            bool isHighTemperature = false;
            bool hasNoCooling = fanSpeed<=0;


            if (!isInfected)
            {
                Console.WriteLine("Персонаж здоров");
            }
            else
            {
                Console.WriteLine("Персонаж заражен");
            }

            if (isHighTemperature && hasNoCooling)
            {
                Console.WriteLine("Угроза повреждения процессора!!!");
            }
            else
            {
                Console.WriteLine("Процессор работает нормально!");
            }








        }
    }
}
