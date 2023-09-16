using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Student> students = new List<Student>();

			string input;
			while ((input = Console.ReadLine()) != "end")
			{
				string[] studentInfo = input.Split();
				string firstName = studentInfo[0];
				string lastName = studentInfo[1];
				int age = int.Parse(studentInfo[2]);
				string city = studentInfo[3];

				Student student = new Student(firstName, lastName, age, city);
				students.Add(student);
			}

			string cityName = Console.ReadLine();

			foreach (var student in students)
			{
				if (student.City == cityName)
				{
					Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
				}
			}

		}
	}
	class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public string City { get; set; }

		public Student(string firstName, string lastName, int age, string city)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			City = city;
		}
	}
}