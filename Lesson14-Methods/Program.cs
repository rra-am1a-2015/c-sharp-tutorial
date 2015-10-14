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

            Console.WriteLine("De som van 4 + 5 = {0}", optelling());

            Console.ReadKey();
        }

        private static void doeDeGroetenVan(string naam)
        {
            Console.WriteLine("Groetjes van {0}", naam);
        }

        private static int optelling()
        {
            int som = 4 + 5;
            return som;
        }


        /* Maak een method die twee getallen kan optellen. Regel de invoer met Console.Readline();
         *


        */
    }
}
