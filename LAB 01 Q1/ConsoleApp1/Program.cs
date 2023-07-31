using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name = Console.ReadLine();
            string batch = Console.ReadLine();

            
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your batch is: " + batch);

            
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
