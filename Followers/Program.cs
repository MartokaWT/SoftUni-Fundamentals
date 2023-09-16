using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Followers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int[]> followersData = new Dictionary<string, int[]>();

			string command;
			while ((command = Console.ReadLine()) != "Log out")
			{
				string[] tokens = command.Split(": ");
				string action = tokens[0];
				string username = tokens[1];

				if (action == "New follower")
				{
					if (!followersData.ContainsKey(username))
					{
						followersData[username] = new int[] { 0, 0 };
					}
				}
				else if (action == "Like")
				{
					if (!followersData.ContainsKey(username))
					{
						followersData[username] = new int[] { 0, 0 };
					}

					int likesCount = int.Parse(tokens[2]);
					followersData[username][0] += likesCount;
				}
				else if (action == "Comment")
				{
					if (!followersData.ContainsKey(username))
					{
						followersData[username] = new int[] { 0, 0 };
					}

					followersData[username][1]++;
				}
				else if (action == "Blocked")
				{
					if (followersData.ContainsKey(username))
					{
						followersData.Remove(username);
					}
					else
					{
						Console.WriteLine($"{username} doesn't exist.");
					}
				}
			}

			Console.WriteLine($"{followersData.Count} followers");
			foreach (var kvp in followersData)
			{
				int totalLikesAndComments = kvp.Value[0] + kvp.Value[1];
				Console.WriteLine($"{kvp.Key}: {totalLikesAndComments}");
			}
		}
	}
}