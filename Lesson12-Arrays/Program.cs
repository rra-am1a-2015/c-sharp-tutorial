using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 12 Arrays";
            

            // We maken een array dat mijn gewicht in kg vastlegt van de afgelopen  10 dagen



            int[] lichaamsgewicht = new int[10];

            // Hoe zetten we een integer in het array
            lichaamsgewicht[0] = 54;
            lichaamsgewicht[1] = 55;
            lichaamsgewicht[2] = 56;
            lichaamsgewicht[3] = 57;
            lichaamsgewicht[4] = 56;
            lichaamsgewicht[5] = 55;
            lichaamsgewicht[6] = 54;
            lichaamsgewicht[7] = 53;
            lichaamsgewicht[8] = 51;
            lichaamsgewicht[9] = 59;
            
            /*
            int i = 0;

            while ( i < lichaamsgewicht.Length)
            {
                // Maak een for-loop die alle tot nu toe ingevoerde gewichten weergeeft pipe-symbol gescheiden.
                for ( int n = 0; n < lichaamsgewicht.Length; n++)
                {
                    Console.Write("{0}\t| ", lichaamsgewicht[n]);
                } 

                Console.Write("\nGeef uw gewicht: ");

                string invoer = Console.ReadLine();

                lichaamsgewicht[i] = Convert.ToInt32(invoer);

                Console.Clear();

                i++;
            }
            */


            string[] dagenVanDeWeek = new string[10];

            dagenVanDeWeek[0] = "maandag";
            dagenVanDeWeek[1] = "dinsdag";
            dagenVanDeWeek[2] = "woensdag";
            dagenVanDeWeek[3] = "donderdag";
            dagenVanDeWeek[4] = "vrijdag";
            dagenVanDeWeek[5] = "zaterdag";
            dagenVanDeWeek[6] = "zondag";
            dagenVanDeWeek[7] = "maandag";
            dagenVanDeWeek[8] = "dinsdag";
            dagenVanDeWeek[9] = "woensdag";

            /*
            for (int m = 0; m < 10; m += 1)
            {
                Console.WriteLine("Ik woog afgelopen {0}: {1} kg",  dagenVanDeWeek[m], lichaamsgewicht[m] );
            }
            */
            // Definieer een array genaamd BMI die 10 float-waarden kan bevatten. Vul het array met berekende 
            // BMI waarden voor iemand met een lengte van 1,80 m en de lichaamsgewicht waarden vermeld in
            // het array lichaamsgewicht. Doe dit met een for-loop
            float lengte = 1.8f;

            float[] bmi;

            bmi = new float[10];

            for (int j = 0; j < bmi.Length; j++)
            {
                bmi[j] = lichaamsgewicht[j] / Convert.ToSingle(Math.Pow((double)lengte, 2));
                Console.WriteLine("Mijn gewicht was {0} {1} kg, mijn BMI is dan {2}", 
                                   dagenVanDeWeek[j], 
                                   lichaamsgewicht[j], 
                                   Math.Round(bmi[j], 1));
            }



            /*
            DateTime[] datum = new DateTime[4];

            int h = 0;
            while ( h < datum.Length)
            {
                for ( int g = 0; g < datum.Length; g++)
                {
                    Console.WriteLine("{0:d}", datum[g]);
                }

                Console.Write("Geef het jaartal: ");
                string invoer = Console.ReadLine();
                int jaartal = Convert.ToInt32(invoer);
                Console.Write("Geef de maand: ");
                invoer = Console.ReadLine();
                int maand = Convert.ToInt32(invoer);
                Console.Write("Geef de dag: ");
                invoer = Console.ReadLine();
                int dag = Convert.ToInt32(invoer);

                datum[h] = new DateTime(jaartal, maand, dag);
                h++;
                Console.Clear();
            }
            */
            /*
            DateTime datum = new DateTime(2015, 10, 2);
            Console.WriteLine("Jaartal: {0} - Maand: {1} - dag: {2} samenvattend: {3:D}",
                                datum.Year, datum.Month, datum.Day, datum.Date );
            */


            // Er is een bmi array gemaakt. Bepaal met een for-loop de minimale BMI- waarde in het array.
            // Schrijf deze waarde naar het console scherm: Uw minimale BMI-waarde was: 27,8

            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            float huidigeMinimumBmi = Single.MaxValue;
            float huidigeMaximumBmi = 0f;
            float somBmi = 0f;
            Console.WriteLine("Mimale waarde float: {0}", huidigeMaximumBmi);

            for (int i = 0; i < bmi.Length; i = i + 1 )
            {
                Console.WriteLine("Mijn bmi-waarde is: {0}", bmi[i]);

                if ( bmi[i] < huidigeMinimumBmi )
                {
                    huidigeMinimumBmi = bmi[i];
                    Console.WriteLine("Mijn huidige laagste BMI-waarde is: {0}", huidigeMinimumBmi);
                }

                if ( bmi[i] > huidigeMaximumBmi )
                {
                    huidigeMaximumBmi = bmi[i];
                    Console.WriteLine("Mijn huidige hoogste BMI-waarde is: {0}", huidigeMaximumBmi);
                }

                /* gemiddelde = som van alle gewichten / aantal gewichten */
                somBmi = somBmi + bmi[i];
            }

            float gemiddeldeBmi = somBmi / bmi.Length;

            Console.WriteLine("De allerlaagste BMI-waarde van deze week was: {0}", huidigeMinimumBmi);
            Console.WriteLine("De allerhoogste BMI-waarde van deze week was: {0}", huidigeMaximumBmi);
            Console.WriteLine("De gemiddelde BMI-waarde van deze week was: {0}", gemiddeldeBmi);


            Console.WriteLine("\n+++++++++++++++++++++++++ -- Foreach Loop -- +++++++++++++++++++++++++++++++++++++++++++++++++\n");

            Console.WriteLine("\n======== -- voorbeeld 1 -- =================\n");

            // Maak een array genaamd voornaam (dus van het type char[])  die als elementen heeft de letters van je voornaam.
            // Vul dit array met je eigen voornaam

            char[] voornaam = new char[] { 'A', 'r', 'j', 'a', 'n' };

            Console.Write("Mijn voornaam is: ");

            foreach ( char lettertje in voornaam )
            {
                Console.Write("{0}", lettertje.ToString());
            }

            Console.WriteLine("\n======== -- voorbeeld 2 -- =================\n");
            // Maak een array met daarin de getallen 0 t/m 8. Het array kan alleen positieve gehele getallen bevatten.
            // Beeld deze getallen af in je consolescherm met een foreach loop

            uint[] getallen = new uint[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

            foreach ( uint getal in getallen )
            {
                Console.WriteLine("Dit is een getal {0}", getal);
            }

            Console.WriteLine("\n======== -- voorbeeld 3 -- =================\n");
            // Maak een array waarin ik een zin kan opslaan. Vul het array met drie zinnen en vraag steeds
            // aan de gebruiker om invoer van een zin. Sla deze ingevoerde zin dan op in het array. Gebruik
            // hierbij een foreach - loop. Geef de ingevoerde zinnen weer op het scherm. Gebruik wederom een\
            // foreach loop

            string[] opslagZinnen = new string[2];

            Console.WriteLine("Deze applicatie leest drie zinnen in die u intypt");
            
            /*
            foreach (string zin in opslagZinnen)
            {
                Console.WriteLine("Type een zin in de console: ");
                string zinnetje = Console.ReadLine();
                opslagZinnen[zin.IndexOf()] = zinnetje; 
            }
            */



            Console.ReadKey();
        }
    }
}
