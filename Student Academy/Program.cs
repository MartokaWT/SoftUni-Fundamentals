using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Academy
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var studentGrades = new Dictionary<string, List<double>>();

			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				string name = Console.ReadLine();
				double grade = double.Parse(Console.ReadLine());

				if (studentGrades.ContainsKey(name))
				{
					studentGrades[name].Add(grade);
				}
				else
				{
					studentGrades[name] = new List<double> { grade };
				}
			}

			var passedStudents = studentGrades.Where(pair => pair.Value.Average() >= 4.50);

			foreach (var pair in passedStudents)
			{
				string name = pair.Key;
				double averageGrade = pair.Value.Average();

				Console.WriteLine($"{name} -> {averageGrade:F2}");
			}

		}
	}
}