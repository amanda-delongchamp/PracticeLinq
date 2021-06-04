using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string> {"Mario Brothers","Pacman","Zelda",
            "Dungeons and Dragons","Tomb Raider","Space Invaders","Centipede"};

            IEnumerable<string> gameNameLength = games.OrderBy(game => game.Length);

            foreach (var g in gameNameLength)
            {
                Console.WriteLine(g);
            }
            
            //var gameNameLength = games.OrderBy(game => game.Length);

            //Console.WriteLine(gameNameLength);

        }
    }
}
