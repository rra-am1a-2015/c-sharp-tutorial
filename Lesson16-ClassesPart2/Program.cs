using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_ClassesPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 16 Classes Part 2";

            Motivatie aanmoediging;

            aanmoediging = new Motivatie("Bert");
           
            Console.WriteLine("Geef mij een aanmoeding: {0}", aanmoediging.aanmoedigen());

            Console.WriteLine("Prijs mij de hemel in: {0}", aanmoediging.bejubelen());

            Console.ReadLine();
        }
    }

    class Motivatie
    {
        // Dit is de standaard constructor van de class. De constructor herken je aan 
        // het feit dat hij dezelfde naam heeft als de class en de method heeft geen
        // return type.
        // Fields
        string naam = "Arjan";

        public Motivatie()
        {

        }

        public Motivatie(string naam)
        {
            this.naam = naam;
        }

        public string aanmoedigen()
        {
            return "Dat heb je weer uitstekend gedaan vandaag " + this.naam;
        }

        public string bejubelen()
        {
            return "Je bent werkelijk fan.....tisch " + this.naam + "!!!";
        }
    }
}
