using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11___for___loop
{
    class Program
    {
        public enum maanden { januari, februari, maart, april, mei, juni, juli, augustus, september, october, november, december };

        static void Main(string[] args)
        {
            Console.Title = "Lesson 11 De for loop";

            // Geef de getallen 0 t/m 10 weer

            for ( int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Schrijf de getallen van 50 naar 0 onder elkaar op het het scherm
            
            for ( int i = 50; i >= 0; i--)
            {
                Console.WriteLine(i.ToString());
            }

            // Maak met een for loop de tafel van 8 zichtbaar op het scherm van 0 t/m 80
            // Output:
            // Dit is de tafel van 8:
            // 0 x 8 = 0
            // 1 x 8 = 8
            // enz..........



            for (int i = 0; i <= 80; i++)
            {
                long antwoord = i * 8;
                Console.WriteLine("{0} x 8 = {1}", i.ToString(), antwoord);
            }


            // Maak een variabele aan van het type maanden
            // en schrijf de mogelijke waarden met een for-loop naar het scherm

            maanden aantalMaanden = maanden.januari;

            //aantalMaanden = aantalMaanden + 1;

            for ( int j = 0; j < 12; j++ )
            {
                Console.WriteLine("De waarde van maand {0} is: {1}", j, aantalMaanden);
                aantalMaanden++;
            }


            // Het Sheraton Hotel in Dubai heeft 120 etages. Hieronder een opsomming
            // van de bestaande etages. Zoals u ziet bestaan de etages 13 en 113 niet.
            // output:
            // Etage 1 bestaat
            // Etage 2 bestaat
            // enz
            Console.WriteLine("");
            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            Console.WriteLine("");
            Console.WriteLine("Het Sheraton Hotel in Dubai heeft 120 etages. Hieronder een opsomming" +
                                 "van de bestaande etages. Zoals u ziet bestaan de etages 13 en 113 niet."
                                 + 
                                     " output:");

            for (int m = 0; m <=120; m++)
            {
                if (((m == 13) || (m == 113))) 
                {
                    continue;
                }
                Console.WriteLine("Etage {0} bestaat", m);
            }

            // Maak een loop die getallen afbeeldt t/m 200
            // Vraag van te voren hoeveel getallen er moeten worden afgebeeld en print deze op het scherm.

            Console.Write("Geef een getal: ");

            string invoer = Console.ReadLine();

            int getal = Convert.ToInt32(invoer);

            for ( int l = 0; l < 200; l++)
            {
                if ( l > getal)
                {
                    break;
                }
                Console.WriteLine(l);
            }
            Console.ReadKey();
        }
    }


}
