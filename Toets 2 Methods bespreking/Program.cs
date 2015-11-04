using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toets_2_Methods_bespreking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Toets 2 Methods Bespreking";
            Console.WriteLine("Geef uw voornaam?");
            string voornaam = Console.ReadLine();
            Console.WriteLine("Geef uw tussenvoegsel?");
            string tussenvoegsel = Console.ReadLine();
            Console.WriteLine("Geef uw achternaam?");
            string achternaam = Console.ReadLine();
            Console.WriteLine("Geef uw leerlingnummer?");
            string leerlingnummer = Console.ReadLine();
            int llnr = Convert.ToInt32(leerlingnummer);

            Console.WriteLine(CombineerGegevens(voornaam, tussenvoegsel, achternaam, llnr));
            Console.ReadKey();
        }

        static string CombineerGegevens(string voornaam, string tussenvoegsel, string achternaam, int leerlingnummer)
        {
            if (leerlingnummer < 5149)
            {
                return "Mijn naam is " + voornaam + " " + tussenvoegsel + " " +
                        achternaam + " " + " en mijn leerlingnummer is " + leerlingnummer;

            }
            else
            {
                return "Mijn naam is " + voornaam + " " + tussenvoegsel + " " +
                        achternaam + " " + " en mijn leerlingnummer is " + leerlingnummer + 
                       " van na 1 september 2015";
            }
        }
    }
}
