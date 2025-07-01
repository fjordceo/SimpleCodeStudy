namespace Episode076
{
    /*
     * ООП
     * Методы объекта класса
     */

    internal class Program
    {
        static Student GetStudent()
        {
            var student = new Student(); // Создание объекта класса Student, который будет представлять студента
            student.Id = Guid.NewGuid(); // Генерация уникального идентификатора для студента
            student.firstName = "Иван"; // Установка имени студента
            student.lastName = "Иванов"; // Установка фамилии студента
            student.middleName = "Иванович"; // Установка отчества студента
            student.age = 20; // Установка возраста студента
            student.group = "Группа 1"; // Установка группы студента
            return student; // Возврат объекта студента
        }
        static void Main(string[] args)
        {
            var firstStudent = GetStudent(); // Получение первого студента
            firstStudent.Print(); // Вызов метода Print для вывода информации о первом студенте


            Console.WriteLine();
            Console.WriteLine();

            var secondStudent = new Student(); // Получение второго пустого студента
            secondStudent.firstName = "Петр"; // Установка имени второго студента
            secondStudent.Print(); // Вызов метода Print для вывода информации о втором студенте (пока без данных)

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(firstStudent.GetFullName());



        }
    }
}
