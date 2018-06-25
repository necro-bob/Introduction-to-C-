using System;

namespace Retirementapp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int retirement = 65;

            int myAge = 25;
            int yourAge = 35;

            string message = "Will we be ready to retire soon?";

            int yearsToRetirementForYou = retirement - yourAge;
            int yearsToRetirementForme = retirement - myAge;

            Console.WriteLine(message);

            Console.WriteLine("Years for you: " + yearsToRetirementForYou);
            Console.WriteLine("Years for me: {0}", yearsToRetirementForme);
        }
    }
}
