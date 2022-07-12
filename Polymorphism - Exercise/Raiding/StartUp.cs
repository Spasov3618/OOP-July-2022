using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class Program
    {
        static void Main(string[] args)
        {
            var player = new List<BaseHero>();
            int n = int .Parse (Console.ReadLine());

            while (player.Count < n)
            {
                string name = Console.ReadLine().TrimEnd();
                string type = Console.ReadLine().TrimEnd();

                if (type == "Druid")
                {
                    player.Add(new Druid(name));
                }
                else if (type == "Paladin")
                {
                    player.Add(new Paladin(name));
                }
                else if (type == "Rogue")
                {
                    player.Add(new Rogue(name));
                }
                else if (type == "Warrior")
                {
                    player.Add(new Warrior(name));
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }




            }
            int power = int.Parse (Console.ReadLine());
            int total = player.Sum(n => n.Power);
            foreach (var item in player)
            {
                Console.WriteLine($"{item.CastAbility().TrimEnd()}");
            }

            if (total>=power)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
