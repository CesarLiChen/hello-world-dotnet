namespace HelloWorld 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, WORLD");
            Console.WriteLine("What is your name");

            var name = Console.ReadLine();
            var currentDate = DateTime.Now;

            // {Environment.NewLine} is a platform and language independent line break.
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.WriteLine("\n");
            Console.ReadKey(true);
        }
    }
}
