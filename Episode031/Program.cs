namespace Episode031

    /*
     * Тернарный оператор в C#
     * [Первый операнд - условие] ? [Второй операнд - если условие истинно] : [Третий операнд - если условие ложно]
     */



{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool accessAllowed = false;
            string storedPassword = "qwerty";
            string enteredPassword = Console.ReadLine();
            int inputData;
            int outputData;
            
            
            accessAllowed = enteredPassword == storedPassword ? true : false;
            Console.WriteLine(accessAllowed);
            
            inputData = int.Parse(Console.ReadLine());
            outputData = inputData < 0 ? 1 : inputData;
            Console.WriteLine(outputData);
            
        }
    }
}
