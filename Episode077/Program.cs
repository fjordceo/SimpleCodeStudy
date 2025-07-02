using System.Reflection;
using System.Security.Cryptography.X509Certificates;


namespace Episode077
/*
 * Модификаторы доступа public и private для членов класса
 */

{
    public class Point
    {

        public int X = 1;
        private int Y=44;
        int z = 3; // По умолчанию члены класса имеют модификатор доступа internal

        private void PrintX()
        {
            Console.WriteLine($"X: {X}");
        }

        public void PrintY()
        {
            Console.WriteLine($"Y: {Y}");
        }



        public void Display()
        {
            PrintX();
            PrintY();
        }
    }






    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(); // Создание объекта класса Point
            point.PrintY(); // Вызов метода для печати Y (доступно, так как метод public)
            point.Display(); // Вызов метода для отображения координат точки
            

            var typeInfo = typeof(Point).GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var field in typeInfo)
            {
                Console.WriteLine($"{field.Name}\t IsPrivate: {field.IsPrivate}\t Is Public: {field.IsPublic}");
            }

            
       
        }
    }
}
