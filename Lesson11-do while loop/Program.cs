using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_do_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 11 Do-While-Loop";

            /*
            int getal = -1;

            
            do
            {
                Console.WriteLine("Geef een getal tussen de 0 en de 5");
                string invoer = Console.ReadLine();
                getal = Convert.ToInt32(invoer);
            }
            while ( getal < 0 || getal > 5 );
            

            while (getal < 0 || getal > 5)
            {
                Console.WriteLine("Geef een getal tussen de 0 en de 5");
                string invoer = Console.ReadLine();
                getal = Convert.ToInt32(invoer);
            }
            */

            // Vraag om een getal en geef dan de tafel van 0 t/m 10 van dit getal. Doe dit met een do while loop
            Console.WriteLine("Geef een getal dan geeft dit programma er de tafel van.");
            Console.Write("Voer een getal in: ");

            string invoer = Console.ReadLine();

            int getal = Convert.ToInt32(invoer);

            Console.WriteLine("Tot welk getal moet de tafel worden weergegeven?");
            Console.Write("Geef het getal: ");

            string invoerBereik = Console.ReadLine();

            int getalBereik = Convert.ToInt32(invoerBereik);

            Console.WriteLine("De tafel van {0} van 0 t/m 10 gaat als volgt:", invoer);
            int teller = 0;
            do
            {
                int product = teller * getal;
                Console.WriteLine("{0} x {1} = {2}", teller, getal, product);
                teller = teller + 1;
            }
            while (teller != (getalBereik + 1));

            Console.ReadKey();
        }
    }
}
