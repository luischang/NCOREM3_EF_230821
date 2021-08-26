using NCOREM3_EF.CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NCOREM3_EF.CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using var context = new MundialDBContext();

            //var person = new Person()
            //{
            //    FullName = "Cristiano Ronaldo"
            //};

            //context.Add(person);
            //context.SaveChanges();

            //var player = new Player()
            //{
            //    FullName = "Lionel Messi",
            //    Dorsal = 30,
            //    DateOfBirth = DateTime.Now,
            //    SoccerPositionId = 3
            //};

            //var player2 = new Player()
            //{
            //    FullName = "Neymar",
            //    Dorsal = 10,
            //    DateOfBirth = DateTime.Now,
            //    SoccerPositionId = 3
            //};

            //var player3 = new Player()
            //{
            //    FullName = "Di Maria",
            //    Dorsal = 7,
            //    DateOfBirth = DateTime.Now,
            //    SoccerPositionId = 4
            //};
            //var player4 = new Player()
            //{
            //    FullName = "Mbappe",
            //    Dorsal = 8,
            //    DateOfBirth = DateTime.Now,
            //    SoccerPositionId = 4
            //};
            //var playerList = new List<Player>();
            //playerList.Add(player);
            //playerList.Add(player2);
            //playerList.Add(player3);
            //playerList.Add(player4);

            //context.AddRange(playerList);
            //context.SaveChanges();

            //Remove Player
            //-->Query by LINQ
            //var search = (from p in context.Player
            //              where p.Dorsal == 7
            //              select p).FirstOrDefault();

            //context.Player.Remove(search);
            //context.SaveChanges();

            //-->Query by Lambda expressions

            //var result = context.Player.Where(x => x.Dorsal == 30).FirstOrDefault();
            //result.FullName = "Leonel Messi Maradona";
            //context.SaveChanges();

            //-->Query

            var players = context.Player.ToList();
            foreach (var item in players)
            {
                Console.WriteLine(item.FullName + " " + item.Dorsal);
            }




        }
    }
}
