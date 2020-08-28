using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamMember newMember = new TeamMember();
            Console.WriteLine("Plan your Heist!");
            Console.Write("Enter team member name:");
            newMember.Name = Console.ReadLine();
            Console.Write("Enter skill level:");
            newMember.skillLevel = int.Parse(Console.ReadLine());
            Console.Write("Enter courage factor:");
            newMember.courage = double.Parse(Console.ReadLine());
            Console.WriteLine($"{newMember.Name} {newMember.skillLevel} {newMember.courage}");
        }
    }
}