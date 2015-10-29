using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_ClassesPart2
{
    class Motivatie
    {
        // Dit is de standaard constructor van de class. De constructor herken je aan 
        // het feit dat hij dezelfde naam heeft als de class en de method heeft geen
        // return type.
        // Fields
        string naam = "Arjan";

        //Constructor
        public Motivatie()
        {

        }


        public Motivatie(string naam)
        {
            this.naam = naam;
        }

        public string aanmoedigen()
        {
            return "Dat heb je weer uitstekend gedaan vandaag " + this.naam;
        }

        public string bejubelen()
        {
            return "Je bent werkelijk fan.....tisch " + this.naam + "!!!";
        }
    }
}
