using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isOdd = n % 2 == 1;

            while (isOdd)
            {
                Console.WriteLine("Please write an even number.");
                n = Math.Abs(short.Parse(Console.ReadLine()));
                isOdd = n % 2 == 1;
            }

            Console.WriteLine($"The number is: {n}");

        }
    }
}