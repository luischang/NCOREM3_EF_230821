using Microsoft.EntityFrameworkCore;
using NCOREM3_EF.DatabaseFirst.Models;
using System;
using System.Linq;

namespace NCOREM3_EF.DatabaseFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using var context = new MundialDB230821Context();

            var players = context.Player.ToList();
            foreach (var item in players)
            {
                Console.WriteLine(item.FullName + " " + item.Dorsal);
            }

            var playersTeam = context.Player
                                     .Include(x => x.SoccerPosition)
                                     .ToList();

            foreach (var item in playersTeam)
            {
                Console.WriteLine(item.FullName + " " + item.Dorsal + "-->" + item.SoccerPosition.Description);
            }
        }
    }
}
