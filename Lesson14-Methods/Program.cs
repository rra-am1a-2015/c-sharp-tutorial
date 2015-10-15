using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_Methods
{
   

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "Lesson 14 Methods";
            string[] namen = new string[] { "de heer Odijk", "de heer de Ruijter", "de heer Hupsel", "mevrouw van de Hombergh"};
            
            Random random = new Random();

            Console.WriteLine("Persoon {0}:", namen[0]);
            // Gebruik een for-loop om de heer Odijk 5 maal de groeten te laten doen.
            // Gebruik de method doeDeGroetenVan()

            for (int i = 0; i < 30; i++ )
            {
                doeDeGroetenVan(namen[random.Next(0,4)]);
            }

            Console.Write("Deze applicatie berekent de som van twee getallen.\n\n" +
                          "Geef het eerste getal: ");
            string invoer = Console.ReadLine  ();

            int getal1 = Convert.ToInt32(invoer);

            Console.Write("Geef het tweede getal: ");

            invoer = Console.ReadLine();

            int getal2 = Convert.ToInt32(invoer);

            Console.WriteLine("De som van {0} + {1} = {2}", getal1, getal2, optelling(getal1,getal2));
            Console.WriteLine("Het verschil van {0} - {1} = {2}", getal1, getal2, aftrekken(getal1, getal2));
            Console.WriteLine("Het product van {0} * {1} = {2}", getal1, getal2, product(getal1, getal2));
            Console.WriteLine("Het quotient van {0} : {1} = {2}", getal1, getal2, quotient(getal1, getal2));
            Console.WriteLine("De modulus van {0} % {1} = {2}", getal1, getal2, modulus(getal1, getal2));
            Console.WriteLine("De som van de drie getallen {0} + {1} + {2} = {3}", getal1, getal2, getal1, optelling(getal1, getal2, getal1));
            Console.ReadKey();
        }

        private static void doeDeGroetenVan(string naam)
        {
            Console.WriteLine("Groetjes van {0}", naam);
        }

        private static int optelling(int getal1, int getal2)
        {
            int som = getal1 + getal2;
            return som;
        }

        private static int optelling(int getal1, int getal2, int getal3)
        {
            int som = getal1 + getal2 + getal3;
            return som;
        }

        private static float product(int getal1, int getal2)
        {
            float product = getal1 * getal2;
            return product;
        }

        private static float quotient(int getal1, int getal2)
        {
            float quotient = (float)getal1 / getal2;
            return quotient;
        }

        private static int modulus(int getal1, int getal2)
        {
            int modulus = getal1 % getal2;
            return modulus;
        }        

        private static int aftrekken(int getal1, int getal2)
        {
            int verschil = getal1 - getal2;
            return verschil;
        }

        // aftrekken (verschil), vermenigvuldigen (product), delen (quotient), modulus (modulus) 

        /* Maak een method die twee getallen kan optellen. Regel de invoer met Console.Readline();
         * De method regelt niet het vragen om twee getallen. Doe dit buiten de method.
         * Maak een method die twee getallen kan vermenigvuldigen. Regel de invoer met Console.Readline();
         * De method regelt niet het vragen om twee getallen. Doe dit buiten de method.
        */
    }
}
