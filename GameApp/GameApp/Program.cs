using System;
using GameApp.Models;
using GameApp.Interfaces;
using System.Threading;

namespace GameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player._name = "alex";
            var x = player._name;
            int milliseconds = 2000;
            
            Console.WriteLine("Please select your race:");
            var races = Enum.GetValues(typeof(Race));
            foreach (var item in races)
            {
                Console.WriteLine(item.ToString());
            }
            //var chosenRace = Console.ReadLine().ToString();
            player.race = Race.Human;
            //Thread.Sleep(milliseconds);
            Console.WriteLine("player race is now: {0}", player.race);
            Console.WriteLine("{0} strengh:{1}",x,player.Strength);
            
            Console.WriteLine("{0} agility:{1}",x,player.Agility);
            Console.WriteLine("{0} int:{1}",x,player.Intelligence);
            //Console.WriteLine("{0} strengt:{1}",x,);
            Console.ReadKey();
        }
    }
}
