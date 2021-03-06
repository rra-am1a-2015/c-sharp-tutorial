﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson7 User Input";
            /*
            Console.Beep(1200, 1000);
            Console.Beep(440, 1000);
            Console.Beep(1200, 1000);
            Console.Beep(440, 1000);
            */

            Console.Write(    "Maak een programmakeuze:\n\n" +
                              "1) Optellen van twee getallen\n" +
                              "2) Vermenigvuldigen van twee kommagetallen\n" +
                              "3) Berekening omtrek van een cirkel\n" + 
                              "4) Berekening oppervlakte van een elipse\n" +
                              "\n\n" +
                              "Maak uw keuze door een getal van 1 t/m 4 in te voeren: ");

            ConsoleKeyInfo invoer = Console.ReadKey();

            //int keuzeGetal = Convert.ToInt32(invoer); // int keuzeGetal = (int)invoer

            if ( invoer.KeyChar == (Char)ConsoleKey.D1)
            {
                Console.WriteLine("\n\nDit programma telt twee getallen bij elkaar op."); ;
                Console.Write("Geef het eerste gehele getal: ");

                object invoer1 = Console.ReadLine();

                Console.WriteLine("De invoer is van het type: {0}", invoer1.GetType());

                int eersteGetal = Convert.ToInt32(invoer1);

                

                Console.Write("Geeft het tweede gehele getal: ");

                invoer1 = Console.ReadLine();

                int tweedeGetal = Convert.ToInt32(invoer1);

                long som = eersteGetal + tweedeGetal;

                Console.WriteLine("De som van {0} + {1} = {2}", eersteGetal, tweedeGetal, som);


                //eersteGetal = eersteGetal + 2;

                //Console.WriteLine("U heeft het getal {0} ingevoerd.", eersteGetal);

            }
            else if (invoer.KeyChar == (char)ConsoleKey.D2)
            {
                Console.WriteLine("\n\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

                Console.WriteLine("Dit programma kan twee kommagetallen met elkaar vermenigvuldigen.");
                Console.Write("Geef de waarde van het eerste kommagetal: ");

                string invoer2 = Console.ReadLine();

                float eersteKommaGetal, tweedeKommaGetal, product;

                eersteKommaGetal = Convert.ToSingle(invoer2);

                Console.Write("Geef de waarde van het tweede kommagetal: ");

                invoer2 = Console.ReadLine();

                tweedeKommaGetal = Convert.ToSingle(invoer2);

                product = eersteKommaGetal * tweedeKommaGetal;

                Console.WriteLine("Het product van {0} x {1} = {2}", eersteKommaGetal,
                                    tweedeKommaGetal, Math.Round(Convert.ToDecimal(product), 2));

            }
            else if (invoer.KeyChar == (char)ConsoleKey.D3)
            {
                Console.WriteLine("\n\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

                Console.WriteLine("Dit programma berekent de omtrek van een cirkel.");
                Console.Write("Geef de straal van de cirkel: ");

                string invoer3 = Console.ReadLine();

                double straal = Convert.ToSingle(invoer3);
                double omtrek = 2 * Math.PI * straal;

                Console.WriteLine("De omtrek van de cirkel met straal {0} is: {1}", straal.ToString(),
                                    Math.Round(omtrek, 0).ToString());
            }
            else if (invoer.KeyChar == (char)ConsoleKey.D4)
            {
                Console.WriteLine("\n\n***************************************************************");

                Console.WriteLine("Dit programma berekent de oppervlakte van een elipse.");
                Console.Write("Geef de lengte van de lange as van de elipse: ");

                string invoer4 = Console.ReadLine();

                double langeAs = Convert.ToDouble(invoer4);

                Console.Write("Geef de lengte van de korte as van de elipse: ");

                invoer4 = Console.ReadLine();

                double korteAs = Convert.ToDouble(invoer4);

                double oppervlakteElipse = Math.PI * langeAs * korteAs;

                Console.WriteLine("De oppervlakte van de elipse met lange as {0} een korte as {1} bedraagt: {2}",
                                   langeAs.ToString(), Convert.ToString(korteAs), Convert.ToString(Math.Round(oppervlakteElipse, 1)));
            }
            else
            {
                Console.WriteLine("\n\nU heeft een niet bestaande keuze gemaakt. Het programma stopt.");
            }
            Console.ReadKey();
        }
    }
}
