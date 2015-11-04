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
            Auto vehicle = new Auto("BMW", "Z4", 5, 4.6f);
            vehicle.Kenmerken();
            vehicle.Carbrand = "Dacia";
            vehicle.Type = "Logan";
            vehicle.AantalDeuren = 2;
            vehicle.BrandstofVerbruik = 13.3f;
            vehicle.Kenmerken();
            Console.ReadKey();
        }
    }
}
