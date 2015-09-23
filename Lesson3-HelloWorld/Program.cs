// Hier worden codebibliotheken toegevoegd d.m.v. een using declaratie
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Hieronder staat een naamruimte. 
   Naamgevingbinnen een namespace moet uniek zijn. Classes leven in namespaces */

namespace Lesson3_HelloWorld
{
    // Het meest minimale programma heeft in ieder geval een class nodig met .....
    class Program
    {
        // ...een method genaamd Main. Dit heet ook 
        // wel het entrypoint van de applicatie. Het startpunt van je applicatie
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Wereld!"); // Commentaar na een coderegel
            Console.WriteLine("Dit is mijn tweede regel!"); /* Dit kan ook */
            Console.Write("Ik maak een lange zin die na dit woord \nop een nieuwe regel verder gaat");
            Console.ReadKey();
        }
    }
}
