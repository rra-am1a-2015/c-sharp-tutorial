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

            // Maak een class rekenen waarvan de constructor twee getallen accepteert (int's). Sla deze
            // twee getallen op als field. En maak 5 methoden in deze class (optellen, aftrekken, vermenigvuldigen
            // delen en modulus. Geef van elke method de uitkomst weer op het scherm d.m.v. het object dat je hebt
            // gemaakt van de class rekenen

            Rekenen rekenopgave = new Rekenen(4, 10);
            Console.WriteLine("De som van {0} + {1} = {2}", rekenopgave.Getal1, rekenopgave.Getal2,
                                rekenopgave.optelling());
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

    // Dit is de class definitie
    class Rekenen
    {
        // Fields
        private int getal1 = 0;
        private int getal2 = 0;

        // Properties
        public int Getal1
        {
            get { return this.getal1; }
        }

        public int Getal2
        {
            get { return this.getal2;  }
        }
        
        // Dit is de constructor
        public Rekenen(int getal1, int getal2)
        {
            this.getal1 = getal1;
            this.getal2 = getal2;
        }

        // Method
        public int optelling()
        {
            int som = this.getal1 + this.getal2;
            return som;
        }
    }
}
