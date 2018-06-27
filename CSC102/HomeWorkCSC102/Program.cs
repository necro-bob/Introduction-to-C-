using System;

namespace HomeWorkCSC102
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.Write("Please enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            
            Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, difference);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, product);

            if (num2 == 0)
            {
                Console.WriteLine("Error: denominator is zero");
            }
            else
            {
                int quotient = num1 / num2;
                Console.WriteLine("{0} / {1} = {2}", num1, num2, quotient);
            }

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
