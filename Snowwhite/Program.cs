using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowwhite
{
	
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Dwarf> dwarfs = new List<Dwarf>();

			string input;
			while ((input = Console.ReadLine()) != "Once upon a time")
			{
				string[] data = input.Split(" <:> ");
				string dwarfName = data[0];
				string dwarfHatColor = data[1];
				int dwarfPhysics = int.Parse(data[2]);

				Dwarf existingDwarf = dwarfs.FirstOrDefault(d => d.Name == dwarfName && d.HatColor == dwarfHatColor);
				if (existingDwarf != null)
				{
					if (dwarfPhysics > existingDwarf.Physics)
					{
						existingDwarf.Physics = dwarfPhysics;
					}
				}
				else
				{
					dwarfs.Add(new Dwarf(dwarfName, dwarfHatColor, dwarfPhysics));
				}
			}

			var sortedDwarfs = dwarfs
				.OrderByDescending(d => d.Physics)
				.ThenByDescending(d => dwarfs.Count(dd => dd.HatColor == d.HatColor))
				.ToList();

			foreach (var dwarf in sortedDwarfs)
			{
				Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
			}
		}
		class Dwarf
		{
			public string Name { get; }
			public string HatColor { get; }
			public int Physics { get; set; }

			public Dwarf(string name, string hatColor, int physics)
			{
				Name = name;
				HatColor = hatColor;
				Physics = physics;
			}
		}
	}
}