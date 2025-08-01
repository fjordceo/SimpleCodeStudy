﻿namespace Episode051;

/* 
 * Область видимости или контекст переменных в C#
 * Конфликты областей видимости
 */

class Program
{
    // Область видимости - это часть программы, в которой переменная доступна для использования.
    int value; // Переменная value объявлена в контексте класса Program, она доступна во всех методах этого класса.
    static int staticValue = 200; // Статическая переменная, доступна в контексте всего класса Program
    
    static void Main(string[] args)
    {
        int money = 100; // Переменная money объявлена в контексте метода Main
        
        
        for (int i = 0; i < 5; i++)
        {
            i++; // Переменная i объявлена в контексте цикла for
        }
        
        // Все что было создано в рамках какого-либо контекста, будет доступно только в этом контексте.
        
        Program program = new Program();
        program.value = 50; // Доступ к переменной value из класса Program, так как она объявлена в контексте класса.
        
        // Статические методы не могут обращаться к нестатическим переменным и методам класса напрямую.
        
    }

    static void Method()
    {
        int money = 200; // Переменная money объявлена в контексте метода Method
        // Эта переменная не конфликтует с переменной money из метода Main, так как они находятся в разных контекстах.
        
        // Переменная i из цикла for в методе Main не доступна здесь, так как она объявлена в другом контексте.
        
    }
    
}