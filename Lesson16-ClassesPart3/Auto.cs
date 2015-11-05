using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_ClassesPart3
{
    class Auto
    {
        //Fields ook wel class-variable genoemd
        private string carbrand = "Nog geen merk gekozen";
        private string type = "Nog geen type gekozen";
        private short aantalDeuren = 5;
        private float brandstofVerbruik;
        private kleur kleurUitvoering;
        private string kenteken;


        //Properties, met getters vraag je de waarde van een Field op
        //met setters verander je de waarde van een Field
        public string Carbrand
        {
            get { return this.carbrand; }
            set { this.carbrand = value; }
        }
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public short AantalDeuren
        {
            get { return this.aantalDeuren; }
            set { this.aantalDeuren = value; }
        }
        public float BrandstofVerbruik
        {
            get { return this.brandstofVerbruik; }
            set { this.brandstofVerbruik = value; }
        }
        public kleur KleurUitvoering
        {
               get { return this.kleurUitvoering; }
               set { this.kleurUitvoering = value; }
        }
        public string Kenteken
        {
            set { this.kenteken = value; }
            get { return this.kenteken; }
        }

        //Constructor
        public Auto()
        {

        }

        public Auto(string carbrand, string type, short aantalDeuren, float brandstofVerbruik,
                        kleur kleurUitvoering, string kenteken)
        {
            this.carbrand = carbrand;
            this.type = type;
            this.aantalDeuren = aantalDeuren;
            this.brandstofVerbruik = brandstofVerbruik;
            this.kleurUitvoering = kleurUitvoering;
            this.kenteken = kenteken;
        }

        //Methods
        public void Kenmerken()
        {
            Console.WriteLine("\n************************************************************************\n" +
                              " Toekomstige automerk\t\t\t{0}\n" +
                              " Toekomstige autotype\t\t\t{1}\n" +
                              " Aantal deuren toekomstige auto:\t{2}\n" +
                              " Het brandstofverbruik is:\t\t{3} liter/100km\n" +
                              " De kleur is:\t\t\t\t{4}\n" +
                              " Het kenteken is:\t\t\t{5}\n" + 
                              "\n************************************************************************\n",
                                 this.carbrand, this.type, this.aantalDeuren, this.brandstofVerbruik,
                                 this.kleurUitvoering, this.kenteken);
        }

    }
}
