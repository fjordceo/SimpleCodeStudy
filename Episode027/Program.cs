﻿namespace Episode027;

/*
 * Ключевое слово Break
 */

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(i);
            if (i == 50)
            {
                break;
            }
        }
    }
}