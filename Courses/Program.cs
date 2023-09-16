using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "end")
				{
					break;
				}

				string[] courseInfo = input.Split(" : ");
				string courseName = courseInfo[0];
				string studentName = courseInfo[1];

				if (!courses.ContainsKey(courseName))
				{
					courses[courseName] = new List<string>();
				}

				courses[courseName].Add(studentName);
			}

			foreach (var course in courses)
			{
				Console.WriteLine($"{course.Key}: {course.Value.Count}");

				foreach (var student in course.Value)
				{
					Console.WriteLine($"-- {student}");
				}
			}
		}
	}
}