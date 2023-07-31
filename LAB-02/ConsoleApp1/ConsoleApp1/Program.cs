using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number1;
            int number2;

            
            Console.WriteLine("Enter the first number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            number2 = int.Parse(Console.ReadLine());

           
            int sum = number1 + number2;

            Console.WriteLine("The sum of the two numbers is: " + sum);

            
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
