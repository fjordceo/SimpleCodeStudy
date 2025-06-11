using static System.Console;

namespace HomeWork001;

class Program
{
    static void Main(string[] args)
    {
        double firstValue;
        double secondValue;
        double thirdValue;
        double resultAr;
        double resultSumm;
        double resultX;
        int resultMoney;
        float USDExchangeRate = 0.012723f;
        float VNDExchangeRate = 317.87f;

        WriteLine("Пожалуйста, введите первое число: ");
        if (!double.TryParse(ReadLine(), out firstValue))
        {
            WriteLine("Ошибка. Введено некорректное число!");
            return;
        }

        WriteLine("Пожалуйста, введите второе число: ");
        if (!double.TryParse(ReadLine(), out secondValue))
        {
            WriteLine("Ошибка. Введено некорректное число!");
            return;
        }

        WriteLine("Пожалуйста, введите третье число: ");
        if (!double.TryParse(ReadLine(), out thirdValue))
        {
            WriteLine("Ошибка. Введено некорректное число!");
            return;
        }


        resultAr = (firstValue + secondValue) / 2;

        //

        resultSumm = firstValue + secondValue + thirdValue; 
        resultX = firstValue * secondValue * thirdValue;    

        WriteLine("Среднеарифметическое введенных вами чисел равно: " + resultAr);
        WriteLine("Сумма всех введенных чисел: " + resultSumm);
        WriteLine("Произведение всех введенных чисел: " + resultX);


        WriteLine("А теперь давай переведем твои рубли в разную валюту. Вот сколько у тебя рублей?");
        if (!int.TryParse(ReadLine(), out resultMoney))
        {
            WriteLine("Ошибка. Введено некорректное число!");
            return;
        }

        WriteLine("Значит у тебя примерно: " + (resultMoney * USDExchangeRate) + "USD");
        WriteLine("И примерно: " + (resultMoney * VNDExchangeRate) + "VND");
        ReadKey();

        
    }
}