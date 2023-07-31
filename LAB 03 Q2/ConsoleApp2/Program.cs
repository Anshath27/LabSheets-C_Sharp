using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string str;

            
            Console.WriteLine("Enter a string: ");
            str = Console.ReadLine();

           
            int vowelCount = 0;

            
            string vowels = "aeiouAEIOU";

            
            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    vowelCount++;
                }
            }

            
            Console.WriteLine("The number of vowels in the string is: " + vowelCount);

            
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
