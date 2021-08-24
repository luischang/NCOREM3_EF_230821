using NCOREM3_EF.CodeFirst.Models;
using System;

namespace NCOREM3_EF.CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using var context = new MundialDBContext();

            var person = new Person()
            {
                FullName = "Cristiano Ronaldo"
            };

            context.Add(person);
            context.SaveChanges();
        }
    }
}
