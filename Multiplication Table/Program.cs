using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int output = 0;

            for (int i = 1; i <= 10; i++)
            {
                output++;
                Console.WriteLine($"{num} X {i} = {output * num}");
                
            }
        }
    }
}