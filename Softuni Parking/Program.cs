using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softuni_Parking
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var parkingDatabase = new Dictionary<string, string>();

			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				string command = Console.ReadLine();
				string[] commandParts = command.Split(' ');

				string action = commandParts[0];
				string username = commandParts[1];

				if (action == "register")
				{
					string licensePlateNumber = commandParts[2];

					if (parkingDatabase.ContainsKey(username))
					{
						string registeredLicensePlate = parkingDatabase[username];
						Console.WriteLine($"ERROR: already registered with plate number {registeredLicensePlate}");
					}
					else
					{
						parkingDatabase[username] = licensePlateNumber;
						Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
					}
				}
				else if (action == "unregister")
				{
					if (parkingDatabase.ContainsKey(username))
					{
						parkingDatabase.Remove(username);
						Console.WriteLine($"{username} unregistered successfully");
					}
					else
					{
						Console.WriteLine($"ERROR: user {username} not found");
					}
				}
			}

			foreach (var pair in parkingDatabase)
			{
				string username = pair.Key;
				string licensePlateNumber = pair.Value;
				Console.WriteLine($"{username} => {licensePlateNumber}");
			}
		}
	}
}