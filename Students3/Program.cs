using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			List<Student> students = new List<Student>();

			for (int i = 0; i < n; i++)
			{
				string[] studentInfo = Console.ReadLine().Split();
				string firstName = studentInfo[0];
				string lastName = studentInfo[1];
				double grade = double.Parse(studentInfo[2]);

				Student student = new Student
				{
					FirstName = firstName,
					LastName = lastName,
					Grade = grade
				};

				students.Add(student);
			}

			students.Sort((s1, s2) => s2.Grade.CompareTo(s1.Grade));

			foreach (var student in students)
			{
				Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
			}
		}
		class Student
		{
			public string FirstName { get; set; }
			public string LastName { get; set; }
			public double Grade { get; set; }
		}
	}
}