using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] numbers = new int[10];

          
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine("The number {0} is even.", numbers[i]);
                }
                else
                {
                    Console.WriteLine("The number {0} is odd.", numbers[i]);
                }
            }

            
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
