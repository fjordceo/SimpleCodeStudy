namespace Episode080
/*
 * Перезагрузка конструктора - это возможность создавать несколько конструкторов в одном классе с разными параметрами.
 */
{
    class Point
    {
        public Point()
        {

        }

        public Point(int x, int y)
        {
            _x = x;
            _y = y;     
        }

        public Point(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        private int _x;
        private int _y;
        private int _z;

        public void Print()
        {
            Console.WriteLine($"Point: ({_x}, {_y})");
        }
    }
        

    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
        }
    }
}
