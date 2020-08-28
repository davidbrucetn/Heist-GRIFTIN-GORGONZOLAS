using System;
using System.Collections.Generic;
using System.Linq;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int scenarioCount = 1;
            List<TeamMember> Team = new List<TeamMember>();
            bool memberCheck = true;
            int successCount = 0;
            int failureCount = 0;
            Console.WriteLine("Plan your Heist!");
            Console.WriteLine("");
            Console.Write("Enter a difficulty level between 1 - 10:");
            int bankDifficulty = (int.Parse(Console.ReadLine()) * 10);

            while (count < scenarioCount)
            {



                int Luck = new Random().Next(-10, 11);
                bankDifficulty = bankDifficulty + Luck;






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
                if (count == 0)
                {
                    Console.Write("How many scenarios would you like to run?");
                    scenarioCount = int.Parse(Console.ReadLine());
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
                    successCount++;
                }
                else
                {
                    Console.WriteLine("You failed!  See you all in the prison cafe!");
                    failureCount++;
                }
                count++;
            }
            Console.WriteLine("");
            Console.WriteLine($"Successful Heists: {successCount}");
            Console.WriteLine("");
            Console.WriteLine($"Failed Heists: {failureCount}");
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