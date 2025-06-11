namespace Episode009;
/*
 * Конвертация строк. Методы Parse и TryParse
 */

class Program
{
    static void Main(string[] args)
    {
        string? str = "5,5";
        string? str2 = "5";
        string? str3 = "555586";
        
        // Метод Parse более узконаправленный, направлен на работу со строковыми типами данных
        double a = double.Parse(str);
        int b = int.Parse(str2);
        
        //Метод TryCatch
        try
        {
            int d = Convert.ToInt32(str3);
            Console.WriteLine("Успешная конвертация");
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка при конвертации");
        }
        
        //Метод TryParse. Пробует преобразовать число, записывает значение в переменную при успешной конвертации.
        //При неуспешном методе возвращает значение по умолчанию
        
        int a3;
        bool result = int.TryParse(str3, out a3);
        
        Console.WriteLine(result);
        
        if (result)
        {
            Console.WriteLine("Операция конвертации прошла успешно, значение: " + a3);
        }
        else
        {
            Console.WriteLine("Конвертация прошла с ошибкой");
        }
        
    }
}