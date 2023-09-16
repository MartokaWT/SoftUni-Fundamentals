using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Users
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var companyEmployees = new Dictionary<string, List<string>>();

			while (true)
			{
				string input = Console.ReadLine();

				if (input == "End")
				{
					break;
				}

				string[] data = input.Split(" -> ");

				string companyName = data[0];
				string employeeId = data[1];

				if (companyEmployees.ContainsKey(companyName))
				{
					if (!companyEmployees[companyName].Contains(employeeId))
					{
						companyEmployees[companyName].Add(employeeId);
					}
				}
				else
				{
					companyEmployees[companyName] = new List<string> { employeeId };
				}
			}

			foreach (var pair in companyEmployees)
			{
				string companyName = pair.Key;
				List<string> employeeIds = pair.Value;

				Console.WriteLine(companyName);

				foreach (string employeeId in employeeIds)
				{
					Console.WriteLine($"-- {employeeId}");
				}
			}
		}
	}
}