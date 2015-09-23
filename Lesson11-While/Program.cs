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
                Console.WriteLine("Hallo {0}", getal);
                //getal += 1;
               
                //getal = getal + 1;
            }

            // Maak een raadspelletje voor het raden van een getal tussen de 1 en 5
            // Als de waarde niet is geraden moet er om nieuwe invoer gevraagd worden.

            int teRadenGetal = 3, getalletje=0;

            Console.Write("Raad een getal tussen de 1 en 5, geef uw waarde: ");
            while (getalletje != teRadenGetal)
            {                
                string invoer = Console.ReadLine();
                getalletje = Convert.ToInt32(invoer);

                if (getalletje == teRadenGetal)
                {
                    Console.WriteLine("U heeft het goede getal geraden, namelijk {0}", teRadenGetal);
                }
                else
                {
                    Console.Write("U heeft het niet goed geraden, probeer het nog maar een keer: ");
                }
            }

            Console.WriteLine("Bedankt voor het spelen.");


            //Console.WriteLine("Ik kan tot 100500 tellen, kijk maar\n1\n2\n3\n4\n5");


            Console.ReadKey();
        }
    }
}
