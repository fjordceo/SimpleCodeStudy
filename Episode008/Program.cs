using System.Globalization;

namespace Episode008;

/*
 * Конвертация строки. Класс Convert
 */

class Program
{
    static void Main(string[] args)
    {
        string? str;
        int a, b, result;

        Console.WriteLine("Пожалуйста, введите первое число");
        str = Console.ReadLine();
        a = Convert.ToInt32(str);
        
        Console.WriteLine("А теперь, второе число");
        str = Console.ReadLine();
        b = Convert.ToInt32(str);
        
        result = a + b;
        
        // Все что складывается со строкой, конвертируется в string!!!
        Console.WriteLine("Сумма введенных тобой чисел = " + result);
        Console.WriteLine();



        string strDouble = "1.9";

        // Создаем экземпляр класса для определения разделителя
        NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
        {
            NumberDecimalSeparator = ".",
        };

        //Аккуратнее с региональными настройками разделителей, используем параметр numberFormatInfo
        double d = Convert.ToDouble(strDouble, numberFormatInfo);

        Console.WriteLine($"Пробный вывод переменной с разделителем: {d}");



    }
}