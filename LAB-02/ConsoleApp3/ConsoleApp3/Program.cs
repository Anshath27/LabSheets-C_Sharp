using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double radius;

            Console.WriteLine("Enter the radius of the circle: ");
            radius = double.Parse(Console.ReadLine());

            
            double area = Math.PI * radius * radius;
            double circumference = 2 * Math.PI * radius;

            
            Console.WriteLine("The area of the circle is: " + area);
            Console.WriteLine("The circumference of the circle is: " + circumference);

           
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
