using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number1;
            int number2;
            int sum;
            int difference;
            int product;
            float quotient;

            
            Console.WriteLine("Enter the first number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            number2 = int.Parse(Console.ReadLine());

            
            sum = number1 + number2;
            difference = number1 - number2;
            product = number1 * number2;
            quotient = number1 / number2;

            
            Console.WriteLine("The sum of the two numbers is: " + sum);
            Console.WriteLine("The difference of the two numbers is: " + difference);
            Console.WriteLine("The product of the two numbers is: " + product);
            Console.WriteLine("The quotient of the two numbers is: " + quotient);

            
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
