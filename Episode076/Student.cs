using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Episode076
{
    internal class Student
    {
        public Guid Id;
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;

        public void Print ()
        {   // Вывод информации о студенте
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Имя: {firstName}");
            Console.WriteLine($"Фамилия: {lastName}");
            Console.WriteLine($"Отчество: {middleName}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Группа: {group}");
        }

        public string GetFullName()
        {
            // Возвращает полное имя студента в формате "Фамилия Имя Отчество"
            return $"{lastName} {firstName} {middleName}";
        }

    }
}
