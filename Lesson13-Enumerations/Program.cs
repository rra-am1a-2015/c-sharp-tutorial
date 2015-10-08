using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Enumerations
{
    enum ijssmaak { Chocolade, Aardbei, Citroen, Vanille, Meloen, Mocca };
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 13 Enumerations";
           
            ijssmaak smaak = ijssmaak.Chocolade;

            ijssmaak[] ijssmaken;

            ijssmaken = new ijssmaak[6];

            ijssmaken[0] = ijssmaak.Aardbei;
            ijssmaken[1] = ijssmaak.Chocolade;

            for ( int j = 0; j < ijssmaken.Length; j++)
            {
                ijssmaken[j] = smaak;
                smaak++;
            }

            string[] mening = new string[6];

            /*
            foreach ( ijssmaak smaakje in ijssmaken)
            {
                int i  = ijssmaken.
                Console.WriteLine("Index i: {0}", ijssmaken.In;
            }
               */

            //Console.WriteLine("Mijn lievelingsijssmaak is: {0}", smaak.ToString());

            // Maak een array ijssmaken die ijssmaak variabelen kan bevatten. Vraag met behulp van een while loop
            // wat de persoon die het programma runt vindt van de verschillende ijssmaken. Sla het commentaar op in een array
            // met de naam ijsmening. Dit is een array dat string variabelen bevat.
            // Alle meningen moeten worden weergegeven in de console.

            int i = 0;

            while( i < 6 )
            {
                Console.WriteLine("Wat is uw mening over {0} ijs: ", ijssmaken[i] );
                string invoer = Console.ReadLine();
                mening[i] = invoer;
                i++;
            }

            Console.Clear();

            for ( int k = 0; k < mening.Length; k++ )
            {

                Console.WriteLine("Uw mening over {0} ijs: \n{1}", ijssmaken[k], mening[k]);
            }
           
            Console.ReadKey();
        }
    }
}
