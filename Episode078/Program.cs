namespace Episode078
/*
 * Инкапсуляция
 */

{
    class Gun
    {
        private bool isLoaded;

        private void Reload()
        {
            Console.WriteLine("Заряжаю...");
            isLoaded = true;
            Console.WriteLine("Заряжено!");
        }

        public void Shoot()
        {
            if (!isLoaded)
            {
                Console.WriteLine("Оружие не заряжено!");
                Reload(); // Перезарядка при попытке выстрела, если оружие не заряжено
            }
            Console.WriteLine("Пыщь пыщь");
            isLoaded = false; // После выстрела оружие считается разряженным
        }

    }







    internal class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun(); // Создание объекта класса Gun
            gun.Shoot();
            Console.WriteLine();
            gun.Shoot(); // Вторая попытка выстрела, когда оружие не заряжено, вызовет перезарядку
        }
    }
}
