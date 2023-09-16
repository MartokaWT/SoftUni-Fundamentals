using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double inputGrade = double.Parse(Console.ReadLine());

			gradeType(inputGrade);
		}

		private static void gradeType(double inputGrade)
		{
			if (inputGrade >= 2 && inputGrade <= 2.99)
			{
				Console.WriteLine("Fail");
			}
			else if (inputGrade >= 3 && inputGrade <= 3.49)
			{
                Console.WriteLine("Poor");
            }
			else if (inputGrade >= 3.50 && inputGrade <= 4.49)
			{
                Console.WriteLine("Good");
            }
			else if (inputGrade >= 4.50 && inputGrade <= 5.49)
			{
                Console.WriteLine("Very good");
            }
			else
			{
				Console.WriteLine("Excellent");
			}
		}
	}
}