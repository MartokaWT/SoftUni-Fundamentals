using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_Week
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int dayInput = int.Parse(Console.ReadLine());
			string[] days = { "Invalid day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

			if (dayInput >= 1 && dayInput <= 7)
			{
				Console.WriteLine(days[dayInput]);
			}
			else
			{
                Console.WriteLine(days[0]);
            }

		}
	}
}