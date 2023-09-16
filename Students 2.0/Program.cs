using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_2._0
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

				bool isDuplicate = false;
				for (int i = 0; i < students.Count; i++)
				{
					if (students[i].FirstName == firstName && students[i].LastName == lastName)
					{
						students[i] = student;
						isDuplicate = true;
						break;
					}
				}

				if (!isDuplicate)
				{
					students.Add(student);
				}
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
}