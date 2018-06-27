using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBin
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1;i <= 100;i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBin!");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Bin");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
