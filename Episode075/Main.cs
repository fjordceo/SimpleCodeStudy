using System.Transactions;

namespace Episode075
{
    /*
     * ООП
     * Класс
     * Объекты класса (экземпляры класса)
     */


    enum Color
    {
        Red,
        Green,
        Blue
    }

    internal class Program
    {
        static void Main(string[] args)
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

            static void Print(Student student)
            {
                // Вывод информации о студенте
                Console.WriteLine($"Id: {student.Id}");
                Console.WriteLine($"Имя: {student.firstName}");
                Console.WriteLine($"Фамилия: {student.lastName}");
                Console.WriteLine($"Отчество: {student.middleName}");
                Console.WriteLine($"Возраст: {student.age}");
                Console.WriteLine($"Группа: {student.group}");
            }





            Point firstPoint = new Point(); // Создание объекта класса Point, который будет представлять первую точку. Выделение памяти под объект класса происходит в куче (heap).
            Point secondPoint = new Point(); // Создание второго объекта класса Point, который будет представлять вторую точку. Выделение памяти под объект класса происходит в куче (heap).

            firstPoint.X = 10; // Установка значения свойства X для первой точки
            firstPoint.Y = 20; // Установка значения свойства Y для первой точки
            firstPoint.Color = Color.Red; // Установка цвета для первой точки

            secondPoint.X = 30; // Установка значения свойства X для второй точки
            secondPoint.Y = 40; // Установка значения свойства Y для второй точки
            secondPoint.Color = Color.Green; // Установка цвета для второй точки

            // Вывод значений свойств X и Y для первой точки
            Console.WriteLine($"Первая точка: X = {firstPoint.X}, Y = {firstPoint.Y}, Color = {firstPoint.Color}");
            Console.WriteLine($"Вторая точка: X = {secondPoint.X}, Y = {secondPoint.Y}, Color = {secondPoint.Color}");
            Console.WriteLine();
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            var firstStudent = GetStudent(); // Создание объекта класса Student, который будет представлять первого студента
            Print(firstStudent); // Вызов метода Print для вывода информации о первом студенте
        }
    }

    class Point
    {
        // Переменная внутри класса называется полем класса
        // В данном классе мы описываем точку в двумерном пространстве, давая ей два свойства: X и Y
       
        public int X;
        public int Y;
        public Color Color; // Добавлено свойство Color для хранения цвета точки
    }

    

       



}
