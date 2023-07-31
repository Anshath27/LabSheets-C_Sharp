using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int salary;
            float taxRate;

          
            Console.WriteLine("Enter the salary: ");
            salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the tax rate: ");
            taxRate = float.Parse(Console.ReadLine());

            
            float tax = salary * taxRate;

            
            int salaryAfterTax = (int)(salary - tax);

            
            Console.WriteLine("The salary after the tax is: " + salaryAfterTax);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
