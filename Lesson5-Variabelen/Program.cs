using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Variabelen
{
    class Program
    {
        static void Main(string[] args)
        {
            string welkomstwoord, afsluitwoord, samenvoeging, voornaam, tussenvoegsel, achternaam;
            byte leeftijd = 47;

            // Dit is camelcase notatie. Alle woorden beginnen met een hoofdletter, behalve de eerste.
            char eersteLetterVoornaam = 'A';
            short tempMin = -40, tempMax = 19;
            int tempVerschil;

            bool aanOfUit;

            uint nietNegatiefGeheelGetal;
            nietNegatiefGeheelGetal = 4294967295;


            



            welkomstwoord = "Dit is mijn eerste string in de programmeertaal C#";
            afsluitwoord = "\nIk heb een hele fijne programmeerdag gehad.";
            voornaam = "Arjan";
            tussenvoegsel = "de";
            achternaam = "Ruijter";
            samenvoeging = welkomstwoord + afsluitwoord;

            tempVerschil = tempMax - tempMin;
            string welOfNiet;
            aanOfUit = true;

            if (aanOfUit)
            {
                welOfNiet = "wel";
            }
            else
            {
                welOfNiet = "niet";
            }

            /*
            Maak een integer variabele met de naam aantalPunten. Geef hem de waarde 0. 
            Test met een if statement of de variabele aantal punten groter ( > )is dan 100
            Zoja, schrijf dan naar het scherm: U heeft meer dan honderd punten, u heeft gewonnen. Zo nee, schrijf dan 
            naar het scherm: Om te winnen moet u meer dan honderd punten halen. 
            Gebruik bovenstaand voorbeeld.
            */

            int aantalPunten = 59;
            int ondergrens, bovengrens;
            string tekst = "";
            ondergrens = 60;
            bovengrens = 150;

            if (aantalPunten > ondergrens && aantalPunten < bovengrens)
            {
                tekst = "U heeft meer dan honderd punten, u heeft gewonnen";
            }
            else
            {
                tekst = "Om te winnen moet u meer dan {0} punten halen en minder dan {1}, u heeft momenteel {2} punten behaald";
            }   

            //Console.WriteLine(welkomstwoord);
            //Console.WriteLine(afsluitwoord);
            //Console.WriteLine(samenvoeging);
            //Console.WriteLine("Mijn naam is: " + voornaam + " " + " " + tussenvoegsel + " " + achternaam);
            //Console.WriteLine("Mijn leeftijd is: " + Convert.ToString(leeftijd));
            Console.WriteLine("De eerste letter van mijn voornaam is: " + eersteLetterVoornaam.ToString());
            Console.WriteLine("Op de Noordpool kan het erg koud worden, wel {0} graden Celsius. maar erg warm, wel {1} graden Celsius.", tempMin, tempMax);
            Console.WriteLine("Het temperatuurverschil kan wel {0} graden Celsius bedragen.", tempVerschil);
            Console.WriteLine("Het licht is op dit moment {0} aangesloten", welOfNiet);
            Console.WriteLine(tekst, ondergrens, bovengrens, aantalPunten);

            Console.ReadKey();
        }
    }
}
