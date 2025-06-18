namespace Episode034;
/*
 * Массивы и циклы
 */

class Program
{
    static void Main(string[] args)
    {
        //Вывод массива на экран через цикл
        
        int[] myArray = { 10, 3, 2, 55 };
        
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }

    }
}

/*
 * Домашние задания
 * 1. Заполнить массив с клавиатуры
 * 2. Вывести массив в обратном порядке
 * 3. Найти сумму четных чисел в массиве
 * 4. Найти наименьшее число в массиве
 */
