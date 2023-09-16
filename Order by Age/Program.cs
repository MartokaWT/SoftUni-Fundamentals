using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_by_Age
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Person> people = new List<Person>();

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "End")
				{
					break;
				}

				string[] personInfo = input.Split();
				string name = personInfo[0];
				string id = personInfo[1];
				int age = int.Parse(personInfo[2]);

				Person person = people.Find(p => p.ID == id);

				if (person == null)
				{
					person = new Person(name, id, age);
					people.Add(person);
				}
				else
				{
					person.Name = name;
					person.Age = age;
				}
			}

			people.Sort((p1, p2) => p1.Age.CompareTo(p2.Age));

			foreach (var person in people)
			{
				Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
			}
		}

		class Person
		{
			public string Name { get; set; }
			public string ID { get; set; }
			public int Age { get; set; }

			public Person(string name, string id, int age)
			{
				Name = name;
				ID = id;
				Age = age;
			}
		}
	}
}