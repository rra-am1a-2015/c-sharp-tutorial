using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_ClassesPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 15 Classes Part 1";

            //int getal = 12;


            // Ik heb van de class Random een nieuw object (instantie) gemaakt.
            // We maken een nieuw object van een class door een speciale method binnen deze class aan te roepen, namelijk
            // de constructor. De constructor heeft altijd dezelfde naam als de class
            Random willekeurigGetal = new Random();

            int getal = willekeurigGetal.Next(120, 134);
            //Console.WriteLine("Op het scherm staat een willekeurig getal tussen de 120 en 134: {0}", getal.ToString() );

            // Maak een elektronisch dobbelsteen (ouderwetse 6 kantige dobbelsteen) en gooi deze 10 keer.
            // Stop de getallen in een array
            // en bereken het gemiddelde.

            Console.WriteLine("Deze applicatie bestaat uit een elektronisch dobbelsteen. Er wordt 10 \n" +
                              "maal mee gegooid. De waarden worden opgeslagen in een array. Van deze \n" +
                              "getallen wordt het gemiddelde berekent.\n" +
                              "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            Random getalletje;

            getalletje = new Random();

            int random  = getalletje.Next(1, 6);

            Console.WriteLine("Mijn willekeurige getal is: {0}", random.ToString());

            int[] willekeurigeGetallenArray = new int[10];

            int som = 0;
            for (int i = 0; i < willekeurigeGetallenArray.Length; i++)
            {
                willekeurigeGetallenArray[i] = getalletje.Next(1, 7);
                Console.WriteLine("Waarde nr: {0}", willekeurigeGetallenArray[i]);
                som += willekeurigeGetallenArray[i];
            }

            float average = (float)som / willekeurigeGetallenArray.Length;

            Console.WriteLine("Het gemiddelde van bovenstaande getallen is: {0} of {1}",
                                    willekeurigeGetallenArray.Average(), average);
            





            Console.ReadKey();
        }
    }
}
