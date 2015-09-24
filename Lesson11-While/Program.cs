using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 11 While";

            int maxGetal = 2, getal = 0;

            while ( getal <= maxGetal )
            {
                getal++;
                //Console.WriteLine("Hallo {0}", getal);
                //getal += 1;
               
                //getal = getal + 1;
            }

            // Maak een raadspelletje voor het raden van een getal tussen de 1 en 5
            // Als de waarde niet is geraden moet er om nieuwe invoer gevraagd worden.


            // Maak een spel waarbij je een getal onder de 20 moet raden. Wanneer je
            // het getal goed hebt geraden wordt je gefeliciteerd en stopt het spel. Je kunt
            // ook op de letter s drukken om het spel zonder het getal geraden te hebben te kunnen stoppen.
            // Je wordt dan niet gefeliciteerd.
            int teRadenGetal = 3, getalletje=0;
            
            Console.Write("Raad een getal tussen de 1 en 5, geef uw waarde: ");
            while (getalletje != teRadenGetal )
            {                
                string invoer = Console.ReadLine();
                getalletje = Convert.ToInt32(invoer);

                if (getalletje == teRadenGetal)
                {
                    Console.WriteLine("U heeft het goede getal geraden, namelijk {0}", teRadenGetal);
                }
                else
                {
                    Console.Write("U heeft het niet goed geraden, druk op 'enter' \n" + 
                                    "als u verder wilt gaan en op 's' om te stoppen: ");
                    ConsoleKeyInfo stoppen = Console.ReadKey();
                    if (stoppen.KeyChar == 's')
                    {
                        getalletje = teRadenGetal;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.Write("Raad een getal tussen de 1 en 5, geef uw waarde: ");
                    }
                }
            }

            Console.WriteLine("\nBedankt voor het spelen.");


            //Console.WriteLine("Ik kan tot 100500 tellen, kijk maar\n1\n2\n3\n4\n5");


            Console.ReadKey();
        }
    }
}
