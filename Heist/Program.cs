using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TeamMember> Team = new List<TeamMember>();

            bool memberCheck = true;
            Console.WriteLine("Plan your Heist!");
            while (memberCheck)
            {
                Console.Write("Enter team member name:");
                TeamMember newMember = new TeamMember();
                newMember.Name = Console.ReadLine();
                if (newMember.Name == "")
                {
                    memberCheck = false;
                }
                else
                {
                    Console.Write("Enter skill level:");
                    newMember.skillLevel = int.Parse(Console.ReadLine());
                    Console.Write("Enter courage factor:");
                    newMember.courage = double.Parse(Console.ReadLine());

                    Team.Add(newMember);

                }
            }
            Console.WriteLine();
            Console.WriteLine($"# of Team Members {Team.Count}");
            Console.WriteLine("Team Members:");
            foreach (TeamMember member in Team)
            {
                Console.WriteLine($"{member.Name} {member.skillLevel} {member.courage}");
            }
            Console.WriteLine();

        }
    }
}