using static System.Console;

namespace HomeWork001;

class Program
{
    static void Main(string[] args)
    {
        #region Data from the user
        double firstValue;
        double secondValue;
        double thirdValue;
        #endregion

        #region Calculated variables
        double resultArithmeticMean;
        double resultSum;
        double resultMiltiply;
        int resultMoney;
        #endregion

        #region Currency Constants
        float usdExchangeRate = 0.012723f;
        float vndExchangeRate = 317.87f;
        #endregion
        
        Write("Пожалуйста, введите первое число: ");
        if (!double.TryParse(ReadLine(), out firstValue))
        {
            WriteLine("Ошибка. Введено некорректное число!");
            return;
        }

        Write("Пожалуйста, введите второе число: ");
        if (!double.TryParse(ReadLine(), out secondValue))
        {
            WriteLine("Ошибка. Введено некорректное число!");
            return;
        }

        Write("Пожалуйста, введите третье число: ");
        if (!double.TryParse(ReadLine(), out thirdValue))
        {
            WriteLine("Ошибка. Введено некорректное число!");
            return;
        }


        resultArithmeticMean = (firstValue + secondValue) / 2;
        resultSum = firstValue + secondValue + thirdValue; 
        resultMiltiply = firstValue * secondValue * thirdValue;    

        WriteLine("Среднеарифметическое введенных вами чисел равно: " + resultArithmeticMean);
        WriteLine("Сумма всех введенных чисел: " + resultSum);
        WriteLine("Произведение всех введенных чисел: " + resultMiltiply);
        
        Write("А теперь давай переведем твои рубли в разную валюту. Вот сколько у тебя рублей?: ");
        if (!int.TryParse(ReadLine(), out resultMoney))
        {
            WriteLine("Ошибка. Введено некорректное число!");
            return;
        }

        WriteLine("Значит у тебя примерно: " + (resultMoney * usdExchangeRate) + "USD");
        WriteLine("И примерно: " + (resultMoney * vndExchangeRate) + "VND");
    }
}