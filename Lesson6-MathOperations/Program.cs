using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Optellen
            int eersteGetal, tweedeGetal;
            double product, som, verschil, quotient, modulo, kwadraat, 
                   macht, combinatie, ophogenMetEen, verlagenMetEen;
            eersteGetal = 4;
            tweedeGetal = 512;
            som = eersteGetal + tweedeGetal;
            verschil = eersteGetal - tweedeGetal;
            product = eersteGetal * tweedeGetal;
            quotient = eersteGetal / tweedeGetal;
            modulo = eersteGetal % tweedeGetal;
            kwadraat = eersteGetal * eersteGetal;
            kwadraat = Math.Pow(Convert.ToDouble(eersteGetal), 2d);
            macht = Math.Pow(Convert.ToDouble(eersteGetal), Convert.ToDouble(tweedeGetal));
            combinatie = eersteGetal * tweedeGetal - tweedeGetal;
            ophogenMetEen = ++eersteGetal;
            verlagenMetEen = --eersteGetal;
            
            Console.WriteLine("{0} + {1} = {2}", eersteGetal, tweedeGetal, som);
            Console.WriteLine("{0} - {1} = {2}", eersteGetal, tweedeGetal, verschil);
            Console.WriteLine("{0} x {1} = {2}", eersteGetal, tweedeGetal, product);
            Console.WriteLine("{0} : {1} = {2}", eersteGetal, tweedeGetal, quotient);
            Console.WriteLine("{0} % {1} = {2}", eersteGetal, tweedeGetal, modulo);
            Console.WriteLine("{0} in het kwadraat = {1}", eersteGetal, kwadraat);
            Console.WriteLine("{0} tot de macht {1} = {2}", eersteGetal, tweedeGetal, macht);
            Console.WriteLine("{0} * {1} - {1} = {2}", eersteGetal, tweedeGetal, combinatie);
            Console.WriteLine("{0} + 1 = {1}", eersteGetal, ophogenMetEen);
            Console.WriteLine("{0} - 1 = {1}", ophogenMetEen, verlagenMetEen);

            int oudeEersteGetal = eersteGetal;
            //eersteGetal = eersteGetal + 3;
            eersteGetal += 3;
            Console.WriteLine("tel drie bij {0} op, resultaat: {1}", oudeEersteGetal, eersteGetal );

            oudeEersteGetal = eersteGetal;
            //eersteGetal = eersteGetal - 3;
            eersteGetal -= 3;
            Console.WriteLine("trek drie af bij {0}, resultaat: {1}", oudeEersteGetal, eersteGetal);

            //vermenigvuldigen
            oudeEersteGetal = eersteGetal;
            //eersteGetal = eersteGetal - 3;
            eersteGetal -= 3;
            Console.WriteLine("trek drie af bij {0}, resultaat: {1}", oudeEersteGetal, eersteGetal);

            //delen
            oudeEersteGetal = eersteGetal;
            //eersteGetal = eersteGetal - 3;
            eersteGetal -= 3;
            Console.WriteLine("trek drie af bij {0}, resultaat: {1}", oudeEersteGetal, eersteGetal);

            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            int demoPlusPlus = 7;
            Console.WriteLine("\nDe variabele demoPlusPlus heeft nu de waarde: {0}", demoPlusPlus);
            demoPlusPlus = demoPlusPlus + 1;
            Console.WriteLine("\nDe bewerking: demoPlusPlus = demoPlusPLus + 1" + 
                              "\n\nzorgt ervoor dat de nieuwe waarde van demoPlusPlus gelijk aan: {0}", demoPlusPlus);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            demoPlusPlus = 12;
            Console.WriteLine("\nDe variabele demoPlusPlus heeft nu de waarde: {0}", demoPlusPlus);
            demoPlusPlus++;
            Console.WriteLine("\nDe bewerking: demoPlusPlus++" +
                              "\n\nzorgt ervoor dat de nieuwe waarde van demoPlusPlus gelijk aan: {0}", demoPlusPlus);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            int demoMinMin = 16;
            Console.WriteLine("\nDe variabele demoPlusPlus heeft nu de waarde: {0}", demoMinMin);
            demoMinMin--;
            Console.WriteLine("\nDe bewerking: demoPlusPlus--" +
                              "\n\nzorgt ervoor dat de nieuwe waarde van demoMinMin gelijk aan: {0}", demoMinMin);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");


            Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            int demoMaalIs = 20;
            Console.WriteLine("\nDe variabele demoaalIs heeft nu de waarde: {0}", demoMaalIs);
            demoMaalIs *= 3;
            Console.WriteLine("\nDe bewerking: demoMaalIs *= 3" +
                              "\n\nzorgt ervoor dat de nieuwe waarde van demoMaalIs gelijk aan: {0}", demoMaalIs);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ReadKey();
        }
    }
}
