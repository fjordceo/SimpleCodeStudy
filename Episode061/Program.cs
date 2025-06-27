namespace Episode061
/*
 * Ключевое слово out используется для передачи параметра по ссылке, позволяя методу изменять значение переменной, переданной в качестве аргумента.
 * Разница между out и ref заключается в том, что out требует, чтобы переменная была инициализирована внутри метода, тогда как ref требует, чтобы переменная была инициализирована перед вызовом метода.
 */

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine($"Before Foo: value = {a}");
            Foo(ref a);
            Console.WriteLine($"After Foo: value = {a}");
            Bar(out a);
            Console.WriteLine($"After Bar: newValue = {a}");

            // Второй вариант присвоения переменной для out
            Bar1(out int newValue); // Объявляем переменную newValue и присваиваем ей значение в методе Bar1

            string? str = Console.ReadLine();
            int.TryParse(str, out int parsedValue);
            System.Console.WriteLine($"Parsed value = {parsedValue}");

        }


        static void Foo(ref int value)
        {
            value++;
            Console.WriteLine($"Foo: value = {value}");
        }

        static void Bar(out int value)
        {
            value = 20; // Обязательно инициализируем переменную!!!!!!
            Console.WriteLine($"Bar: value = {value}");
        }
        
        static void Bar1(out int value)
        {
            value = 30; // Обязательно инициализируем переменную!!!!!!
            Console.WriteLine($"Bar1: value = {value}");
        }
    }
}
