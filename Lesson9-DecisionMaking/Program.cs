using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("U moet in dit programma proberen het verborgen getal\n" +
                              "te raden. Het is niet moeilijk, maar u heeft maar een\n" +
                              "kans. Doe je best..............\n\n");
            Console.WriteLine("==========================================================");
            Console.Write("Geef een getal tussen de 0 en de 50: ");

            string invoer = Console.ReadLine();

            int getal = Convert.ToInt32(invoer);
                
            int teRadenGetal1 = 24, teRadenGetal2 = 42, teRadenGetal3 = 12;

            if (getal == teRadenGetal1) // Wat tussen haakjes staat kan true of false zijn
            {
                Console.WriteLine("U heeft het getal {0} geraden, gefeliciteerd.\n" +
                                  "U kunt uw vliegtickets naar Hawai ophalen bij de dichtsbijzijnde AH", getal);
            }
            else if( getal == teRadenGetal2 )
            {
                Console.WriteLine("U heeft het getal {0} geraden, gefeliciteerd.\n" +
                                  "U kunt uw kaartje voor de boot ophalen bij Lidl", getal);             
            }
            else if (getal == teRadenGetal3)
            {
                Console.WriteLine("U heeft het getal {0} geraden, gefeliciteerd.\n" +
                                  "U kunt uw kaartje de efteling ophalen bij Ikea", getal);
            }
            else
            {
                Console.WriteLine("U heeft de volgende waarde ingevoerd: {0}. U heeft het getal niet geraden\n" +
                                   "en daarmee het spel verloren. Try again next time!", getal);
            }

            if ( getal > 20 && getal < 25 )
            {
                Console.WriteLine("Het ingevoerde getal is groter dan 20 en kleiner dan 25");
            }
            else
            {
                Console.WriteLine("Het ingevoerde getal is kleiner dan 20 of groter dan 25");
            }

            Console.Title = "Lesson 9 Decision Making";
            Console.ReadKey();
        }
    }
}
