using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_ClassesPart2
{
    // Dit is de class definitie
    class Rekenen
    {
        // Fields
        private int getal1 = 0;
        private int getal2 = 0;

        // Properties
        public int Getal1
        {
            get { return this.getal1; }
            set { this.getal1 = value; }
        }

        public int Getal2
        {
            get { return this.getal2; }
            set { this.getal2 = value; }
        }

        // Dit is de constructor
        public Rekenen(int getal1, int getal2)
        {
            this.getal1 = getal1;
            this.getal2 = getal2;
        }

        // Method
        public int optelling()
        {
            int som = this.getal1 + this.getal2;
            return som;
        }

        public float product()
        {
            float product = this.getal1 * this.getal2;
            return product;
        }

        public float quotient()
        {
            float quotient = (float)this.getal1 / this.getal2;
            return quotient;
        }

        public int modulus()
        {
            int modulus = this.getal1 % this.getal2;
            return modulus;
        }

        public int aftrekken()
        {
            int verschil = this.getal1 - this.getal2;
            return verschil;
        }

        public void show()
        {
            Console.WriteLine("De som van {0} + {1} = {2}", this.Getal1, this.Getal2,
                                this.optelling());
            Console.WriteLine("Het verschil van {0} - {1} = {2}", this.Getal1, this.Getal2,
                                this.aftrekken());
            Console.WriteLine("Het quotient van {0} / {1} = {2}", this.Getal1, this.Getal2,
                                this.quotient());
            Console.WriteLine("De modulus van {0} % {1} = {2}", this.Getal1, this.Getal2,
                                this.modulus());
            Console.WriteLine("Het product van {0} * {1} = {2}", this.Getal1, this.Getal2,
                                this.product());
        }
    }
}
