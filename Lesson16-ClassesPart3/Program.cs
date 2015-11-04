using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_ClassesPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Lesson 16 Classes Part 3");
            Auto vehicle = new Auto("BMW", "Z4");
            Console.WriteLine("Mijn toekomstige auto is van het merk {0} en type {1}",
                                 vehicle.Carbrand, vehicle.Type);
            vehicle.Carbrand = "Dacia";
            vehicle.Type = "Logan";
            Console.WriteLine("Mijn toekomstige auto is van het merk {0} en type {1}",
                                 vehicle.Carbrand, vehicle.Type);
            Console.ReadKey();
        }
    }
}
