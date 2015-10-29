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
            rekenopgave.show();
            rekenopgave.Getal1 = 34;
            rekenopgave.Getal2 = 56;
            rekenopgave.show();

            Console.ReadLine();
        }
    }

   

    
}
