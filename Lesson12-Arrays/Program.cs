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

            lichaamsgewicht[0] = 10;

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


            for (int i = 0; i < 10; i += 1)
            {
                Console.WriteLine("Ik woog afgelopen {0}: {1} kg",  dagenVanDeWeek[i], lichaamsgewicht[i] );
            }


            //Console.WriteLine("Ik woog afgelopen {0}: {1} kg", dagenVanDeWeek[0], lichaamsgewicht[0]);
            //Console.WriteLine("Ik woog afgelopen {0}: {1} kg", dagenVanDeWeek[1], lichaamsgewicht[1]);


            Console.ReadKey();
        }
    }
}
