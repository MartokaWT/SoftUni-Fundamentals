using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Challenger
{
	class Player
	{
		public string Name { get; set; }
		public Dictionary<string, int> Positions { get; set; }

		public Player(string name)
		{
			Name = name;
			Positions = new Dictionary<string, int>();
		}

		public void AddPosition(string position, int skill)
		{
			if (!Positions.ContainsKey(position))
			{
				Positions.Add(position, skill);
			}
			else if (skill > Positions[position])
			{
				Positions[position] = skill;
			}
		}

		public int GetTotalSkill()
		{
			return Positions.Values.Sum();
		}

		public bool HasPosition(string position)
		{
			return Positions.ContainsKey(position);
		}

		public int GetSkillForPosition(string position)
		{
			return Positions.ContainsKey(position) ? Positions[position] : 0;
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, Player> players = new Dictionary<string, Player>();

			string input;
			while ((input = Console.ReadLine()) != "Season end")
			{
				string[] data = input.Split(" -> ");
				if (data.Length == 3)
				{
					string playerName = data[0];
					string position = data[1];
					int skill = int.Parse(data[2]);

					if (!players.ContainsKey(playerName))
					{
						players[playerName] = new Player(playerName);
					}

					players[playerName].AddPosition(position, skill);
				}
				else if (input.Contains(" vs "))
				{
					string[] duelData = input.Split(" vs ");
					string player1 = duelData[0];
					string player2 = duelData[1];

					if (players.ContainsKey(player1) && players.ContainsKey(player2))
					{
						Player playerOne = players[player1];
						Player playerTwo = players[player2];

						List<string> commonPositions = playerOne.Positions.Keys.Intersect(playerTwo.Positions.Keys).ToList();
						if (commonPositions.Any())
						{
							int totalSkillPlayerOne = playerOne.GetSkillForPosition(commonPositions[0]);
							int totalSkillPlayerTwo = playerTwo.GetSkillForPosition(commonPositions[0]);

							if (totalSkillPlayerOne > totalSkillPlayerTwo)
							{
								players.Remove(playerTwo.Name);
							}
							else if (totalSkillPlayerTwo > totalSkillPlayerOne)
							{
								players.Remove(playerOne.Name);
							}
						}
					}
				}
			}

			var sortedPlayers = players.Values
				.OrderByDescending(p => p.GetTotalSkill())
				.ThenBy(p => p.Name)
				.ToList();

			foreach (var player in sortedPlayers)
			{
				Console.WriteLine($"{player.Name}: {player.GetTotalSkill()} skill");
				foreach (var position in player.Positions.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
				{
					Console.WriteLine($"- {position.Key} <::> {position.Value}");
				}
			}
		}
	}
}