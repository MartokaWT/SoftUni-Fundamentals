using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Army
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Dictionary<string, List<Dragon>> dragonsByType = new Dictionary<string, List<Dragon>>();

			for (int i = 0; i < n; i++)
			{
				string[] input = Console.ReadLine().Split();
				string type = input[0];
				string name = input[1];
				int? damage = ParseNullableInt(input[2]);
				int? health = ParseNullableInt(input[3]);
				int? armor = ParseNullableInt(input[4]);

				if (!dragonsByType.ContainsKey(type))
				{
					dragonsByType[type] = new List<Dragon>();
				}

				Dragon existingDragon = dragonsByType[type].FirstOrDefault(d => d.Name == name);
				if (existingDragon != null)
				{
					existingDragon.Damage = damage ?? existingDragon.Damage;
					existingDragon.Health = health ?? existingDragon.Health;
					existingDragon.Armor = armor ?? existingDragon.Armor;
				}
				else
				{
					dragonsByType[type].Add(new Dragon(name, damage, health, armor));
				}
			}

			foreach (var kvp in dragonsByType)
			{
				string type = kvp.Key;
				List<Dragon> dragons = kvp.Value;
				double avgDamage = dragons.Average(d => d.Damage ?? 45);
				double avgHealth = dragons.Average(d => d.Health ?? 250);
				double avgArmor = dragons.Average(d => d.Armor ?? 10);

				Console.WriteLine($"{type}::({avgDamage:F2}/{avgHealth:F2}/{avgArmor:F2})");
				foreach (var dragon in dragons.OrderBy(d => d.Name))
				{
					Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage ?? 45}, health: {dragon.Health ?? 250}, armor: {dragon.Armor ?? 10}");
				}
			}
			static int? ParseNullableInt(string input)
			{
				return input == "null" ? null : int.Parse(input);
			}
		}

	}
	class Dragon
	{
		public string Name { get; set; }
		public int? Damage { get; set; }
		public int? Health { get; set; }
		public int? Armor { get; set; }

		public Dragon(string name, int? damage, int? health, int? armor)
		{
			Name = name;
			Damage = damage;
			Health = health;
			Armor = armor;
		}
	}
}