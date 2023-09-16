using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var resourceQuantities = new Dictionary<string, long>();

			while (true)
			{
				string resource = Console.ReadLine();

				if (resource == "stop")
					break;

				long quantity = long.Parse(Console.ReadLine());

				if (resourceQuantities.ContainsKey(resource))
					resourceQuantities[resource] += quantity;
				else
					resourceQuantities[resource] = quantity;
			}

			foreach (var pair in resourceQuantities)
			{
				string resource = pair.Key;
				long quantity = pair.Value;
				Console.WriteLine($"{resource} -> {quantity}");
			}

		}
	}
}