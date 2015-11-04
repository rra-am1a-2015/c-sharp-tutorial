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

        //Constructor
        public Auto()
        {

        }

        public Auto(string carbrand, string type)
        {
            this.carbrand = carbrand;
            this.type = type;
        }

        //Methods
        

    }
}
