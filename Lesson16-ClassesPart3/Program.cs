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
            Auto vehicle = new Auto("BMW", "Z4", 5, 4.6f, kleur.Goud, "ST-FZ-28");
            vehicle.Kenmerken();

            // We gaan nu het object vehicle veranderen d.m.v. de properties
            vehicle.Carbrand = "Dacia";
            vehicle.Type = "Logan";
            vehicle.AantalDeuren = 2;
            vehicle.BrandstofVerbruik = 13.3f;
            vehicle.KleurUitvoering = kleur.Brons;
            vehicle.Kenteken = "HB-58-ZP";
            vehicle.Kenmerken();

            Console.WriteLine("Maak een array waarin je een Auto object kunt plaatsen.");

            Auto[] cars = new Auto[5]
            {
                new Auto("Ford", "Mondeo", 5, 2.4f, kleur.Zilver, "HB-ZP-58"),
                new Auto("Hyundai", "Pony", 5, 5f, kleur.Rood, "AA-ZP-34"),
                new Auto("Mercedes", "SLK", 5, 5.6f, kleur.Groen, "HB-AA-58"),
                new Auto("Fiat", "500", 2, 12f, kleur.Brons, "CV-ZP-48"),
                new Auto("Bugatti", "Rampo", 2, 20f, kleur.Blauw, "XX-ZP-VV")
            };

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].Kenmerken();
            }









            Console.ReadKey();
        }
    }
}
