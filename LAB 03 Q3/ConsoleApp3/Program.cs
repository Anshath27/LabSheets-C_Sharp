using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number;

            
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            
            int sum = 0;

            
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

           
            Console.WriteLine("The sum of the digits is: " + sum);

            
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
