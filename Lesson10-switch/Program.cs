using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_switch
{

    class Program
    {
        enum dagVanDeWeek { Maandag, Dinsdag, Woensdag, Donderdag, Vrijdag, Zaterdag, Zondag }

        static void Main(string[] args)
        {
            Console.Title = "Lesson10 Switch";

            /*
            Console.Write("Geef een getal tussen de 1 en de 3: ");

            ConsoleKeyInfo invoer = Console.ReadKey();

            
            if ( invoer.KeyChar == (char)ConsoleKey.D1 )
            {
                Console.WriteLine("\nEr is op de een gedrukt");
            }
            else if (invoer.KeyChar == (char)ConsoleKey.D2)
            {
                Console.WriteLine("\nEr is op de twee gedrukt");
            }
            else if (invoer.KeyChar == (char)ConsoleKey.D3)
            {
                Console.WriteLine("\nEr is op de drie gedrukt");
            }
            else
            {
                Console.WriteLine("\nEr is op foutieve toets gedrukt");
            }
            


            switch ( invoer.KeyChar)
            {
                case (char)ConsoleKey.D1:                    
                    Console.WriteLine("\nEr is op de een gedrukt");
                    Console.WriteLine("\nDat is goed gedaan");
                    break;
                case (char)ConsoleKey.D2:
                    Console.WriteLine("\nEr is op de twee gedrukt");
                    break;
                case (char)ConsoleKey.D3:
                    Console.WriteLine("\nEr is op de drie gedrukt");
                    break;
                default:
                    Console.WriteLine("\nEr is op een niet geoorloofde toets gedrukt");
                    break;
            }
            */
            int getal = 100;
            dagVanDeWeek dag = dagVanDeWeek.Zaterdag;

            switch ( dag )
            {
                case dagVanDeWeek.Maandag:
                    Console.WriteLine("{0} is de eerste dag van de week", dag);
                    break;
                case dagVanDeWeek.Dinsdag:
                    Console.WriteLine("{0} is de tweede dag van de week", dag);
                    break;
                case dagVanDeWeek.Woensdag:
                    Console.WriteLine("{0} is de derde dag van de week", dag);
                    break;
                case dagVanDeWeek.Donderdag:
                    Console.WriteLine("{0} is de vierde dag van de week", dag);
                    break;
                case dagVanDeWeek.Vrijdag:
                    Console.WriteLine("{0} is de vijfde dag van de week", dag);
                    break;
                case dagVanDeWeek.Zaterdag:
                    Console.WriteLine("{0} is de zesde dag van de week", dag);
                    break;
                case dagVanDeWeek.Zondag:
                    Console.WriteLine("{0} is de zevende dag van de week", dag);
                    break;
                default:
                    Console.WriteLine("Deze dag is een niet bestaande dag");
                    break; 
            }

            // Maak een switch case statement voor het bepalen van de dag van de week




            Console.ReadKey();
        }
    }
}
