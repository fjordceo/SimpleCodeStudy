﻿namespace Episode017
{
    /*
     * Конструкция if, else и else if в C#. Условные операторы.
     * 
     */

    /*
     *          if (утверждение или условие, булевое значение)
     *          {
     *              действия, которые выполняются, если условие истинно
     *          }
     *          else
     *          {
     *              действия, которые выполняются, если условие ложно
     *          }   
     */

    internal class Program
    {
        static void Main(string[] args)
        {


            int number = 5;
            bool isInfected = false;

            if (isInfected)
            {
                Console.WriteLine("Вирус обнаружен!");
            }
            else
            {
                Console.WriteLine("Вирус не обнаружен!");
            }


            if (number == 10)
            {
                Console.WriteLine("Число равно 10");
            }
            else
            {
                Console.WriteLine("Число не равно 10");
            }







        }
    }
}

// Домашнее задание: Написать программу , которая проверяет, является ли число четным или нечетным.
// Число должно быть введено с клавиатуры. 
