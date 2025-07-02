namespace Episode082
/*
 * Свойства (Properties) в C# позволяют управлять доступом к полям класса.
 * 
 * Автоматические свойства позволяют создавать свойства без явного определения полей.
 */

{
    class Point
    {
        private int x;


        public void SetX(int x) // Сеттер
        {
            if (x < 1)
            {
                this.x = 1;
                return;
            }
            if (x > 5)
            {
                this.x = 5;
                return;
            }
            this.x = x;
        }

        public int GetX() // Геттер
        {
            return x;
        }

        public void Print()
        {
            Console.WriteLine($"Point: X = {x}");
        }

       
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////
       
        private int y;

        public int Y
        {
            get { return y; } // Аксессор геттера
            set // Аксессор сеттера
            { 
                if (value < 1)
                {
                    y = 1; 
                    return;
                }
                if (value>5)
                {
                    y = 5;
                    return;
                }
                y = value; 
            }
        }

        /// ////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public int z { get; set; } // Автоматическое свойство с приватным сеттером
    }







    internal class Program
    {
        static void Main(string[] args)
        {
            
            Point point = new Point();
            point.SetX(10);
            point.Print();
            point.Y = 10;
            int y = point.Y; 
            point.z = 10; // Автоматическое свойство


        }
    }
}
