using System;
using System.Collections.Generic;
using System.Linq;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TeamMember> Team = new List<TeamMember>();

            int bankDifficulty = 100;
            int Luck = new Random().Next(-10, 11);
            bankDifficulty = bankDifficulty + Luck;
            Console.WriteLine($"Bank Difficulty Level: {bankDifficulty}");

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
            // Console.WriteLine($"# of Team Members {Team.Count}");
            // Console.WriteLine("Team Members:");
            //displayTeam(Team);
            int sumSkills = Team.Sum(memberObj => memberObj.skillLevel);
            Console.WriteLine("**************** Heist Report *****************");
            Console.WriteLine($"Team Combined Skill Level: {sumSkills}");
            Console.WriteLine($"Bank Difficulty Level: {bankDifficulty}");
            Console.WriteLine();
            if (sumSkills >= bankDifficulty)
            {
                Console.WriteLine("Congratulations! Let's go to Mexico!");
            }
            else
            {
                Console.WriteLine("You failed!  See you all in the prison cafe!");
            }

        }

        static void displayTeam(List<TeamMember> Team)
        {
            foreach (TeamMember member in Team)
            {
                Console.WriteLine($"{member.Name} {member.skillLevel} {member.courage}");
            }
        }

    }
}