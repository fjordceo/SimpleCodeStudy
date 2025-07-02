namespace Episode079
/*
 * Конструктор класса - спеиальный метод, который вызывается при создании объекта класса.
 * 
 * Конструктор по умолчанию
 */

{
    class Gun
    {
        // Конструктор с параметрами
        public Gun(bool isLoaded)
        {
            _isLoaded = isLoaded;
        }

        private bool _isLoaded;

        private void Reload()
        {
            Console.WriteLine("Заряжаю...");
            _isLoaded = true;
            Console.WriteLine("Заряжено!");
        }

        public void Shoot()
        {
            if (!_isLoaded)
            {
                Console.WriteLine("Оружие не заряжено!");
                Reload(); 
            }
            Console.WriteLine("Пыщ пыщ");
            _isLoaded = false; 
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun(isLoaded: false);  // Это конструктор по умолчанию, который вызывается автоматически при создании объекта класса Gun.
            gun.Shoot();
            Console.WriteLine();
            gun.Shoot(); 
        }
    }
}
