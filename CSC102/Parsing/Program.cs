using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age");
            string yourAge = Console.ReadLine();
            int yourAgeAsInt = int.Parse(yourAge);

            yourAgeAsInt += 1;

            Console.WriteLine(yourAgeAsInt);


        }
    }
}
