using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamwork_Projects
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int countOfTeams = int.Parse(Console.ReadLine());

			Dictionary<string, string> teams = new Dictionary<string, string>();
			Dictionary<string, List<string>> members = new Dictionary<string, List<string>>();

			for (int i = 0; i < countOfTeams; i++)
			{
				string[] input = Console.ReadLine().Split('-');
				string creator = input[0];
				string teamName = input[1];

				if (teams.ContainsKey(teamName))
				{
					Console.WriteLine($"Team {teamName} was already created!");
					continue;
				}

				if (teams.ContainsValue(creator))
				{
					Console.WriteLine($"{creator} cannot create another team!");
					continue;
				}

				teams.Add(teamName, creator);
				members.Add(teamName, new List<string>());

				Console.WriteLine($"Team {teamName} has been created by {creator}!");
			}

			string assignment;
			while ((assignment = Console.ReadLine()) != "end of assignment")
			{
				string[] input = assignment.Split("->");
				string user = input[0];
				string teamName = input[1];

				if (!teams.ContainsKey(teamName))
				{
					Console.WriteLine($"Team {teamName} does not exist!");
					continue;
				}

				if (members.Any(m => m.Value.Contains(user)) || teams.ContainsValue(user))
				{
					Console.WriteLine($"Member {user} cannot join team {teamName}!");
					continue;
				}

				members[teamName].Add(user);
			}

			foreach (var team in members.OrderByDescending(t => t.Value.Count).ThenBy(t => t.Key))
			{
				if (team.Value.Count == 0)
				{
					continue;
				}

				Console.WriteLine(team.Key);
				Console.WriteLine($"- {teams[team.Key]}");

				foreach (var member in team.Value.OrderBy(m => m))
				{
					Console.WriteLine($"-- {member}");
				}
			}

			Console.WriteLine("Teams to disband:");
			foreach (var team in members.OrderBy(t => t.Key))
			{
				if (team.Value.Count == 0)
				{
					Console.WriteLine(team.Key);
				}
			}
		}
	}
}