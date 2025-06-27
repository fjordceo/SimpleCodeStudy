namespace Episode062

/*
 * ключевое слово in
 * используется для передачи параметра по ссылке, но в отличие от ref и out, оно не позволяет изменять значение переменной внутри метода
 * in позволяет передавать большие структуры данных по ссылке, избегая копирования, что может быть полезно для производительности
 * Так же это влияет на безопасность кода, так как гарантирует, что значение не будет изменено внутри метода
 */

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine($"Before Foo: value = {a}");
            Foo(in a); // Передаем значение по ссылке, но не можем его изменить

        }

        static void Foo(in int value)
        {
            Console.WriteLine($"Foo: value = {value}");
            int newValue = value + 10; // Создаем новую переменную на основе in-параметра
            Console.WriteLine($"Foo: newValue = {newValue}");
        }
    }
}
