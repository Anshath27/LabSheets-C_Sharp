using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int startNumber;

            
            int endNumber;

            
            Console.WriteLine("Enter the starting number: ");
            startNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ending number: ");
            endNumber = int.Parse(Console.ReadLine());

            
            int sum = 0;

            
            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }

            
            Console.WriteLine("The sum of the odd numbers is: " + sum);

            
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
