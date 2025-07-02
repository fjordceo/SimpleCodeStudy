using System.Runtime.CompilerServices;

namespace Episode081
/*
 * Ключевое слово this в C# используется для ссылки на текущий экземпляр класса.
 */

{
    class Student
    {
        public Student(string lastName, DateTime birthday) // Конструктор с двумя параметрами
        {
            this.lastName = lastName;
            this.birthday = birthday;
        }
       

        public Student(string lastName, string firstName, string middleName, DateTime birthday):this(lastName, birthday) // Конструктор с четырьмя параметрами
        {
            this.firstName = firstName;
            this.middleName = middleName;
        }

        public Student(Student student) // Конструктор копирования
        {
            this.firstName = student.firstName;
            this.middleName = student.middleName;

            this.lastName = student.lastName;
            this.birthday = student.birthday;
        }

        private string firstName;
        private string middleName;
        private string lastName;
        private DateTime birthday;

        public void Print()
        {
            Console.WriteLine($"Student: {lastName} {firstName} {middleName}, Birthday: {birthday.ToShortDateString()}");
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName; // Использование this для ссылки на поле класса
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ivanov", "Ivan", "Ivanovich", new DateTime(2000, 1, 1));
            Student student2 = new Student("Petrov", "Oleg", "Vladimirovich", new DateTime(2001, 2, 2));
            student1.Print();
            student2.Print();
        }
    }
}
