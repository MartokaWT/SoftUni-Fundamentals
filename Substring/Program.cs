using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string inputOne = Console.ReadLine();
			string inputTwo = Console.ReadLine();

			int index = inputTwo.IndexOf(inputOne);

			while (index != -1) 
			{
				inputTwo = inputTwo.Remove(index, inputOne.Length);
				index = inputTwo.IndexOf(inputOne);
			}

            Console.WriteLine(inputTwo);
        }
	}
}