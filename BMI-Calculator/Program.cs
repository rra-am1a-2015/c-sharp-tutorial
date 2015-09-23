using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "BMI Calculater";

            Console.Write("Dit is uw persoonlijke BMI calclator. Dit programma doet een uitspraak\n" + 
                              "over uw BMI (Body Mass Index). Deze index wordt berekent met behulp van\n" +
                              "twee door u in te voeren waarden:\n\n" +
                              "1) Uw lengte in meters\n" +
                              "2) Uw gewicht in kilogram\n" +
                              "+++++++++++++++++++++++++++++++\n" +
                              "\n" +
                              "Geef uw gewicht in kilogram: ");

            string invoer = Console.ReadLine();

            double gewicht = Convert.ToDouble(invoer);

            Console.Write("Geef uw lengte in meters (gebruik een komma als scheidingsteken): ");

            invoer = Console.ReadLine();

            double lengte = Convert.ToDouble(invoer);

            double bmi = gewicht / Math.Pow(lengte, 2);

            if (bmi < 18.5)
            {
                Console.WriteLine("U heeft ondergewicht");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("U heeft een normaal gewicht");
            }
            else if (bmi >= 25 && bmi < 27)
            {
                Console.WriteLine("U heeft licht overgewicht");
            }
            else if (bmi >= 27 && bmi < 30)
            {
                Console.WriteLine("U heeft matig overgewicht");
            }
            else if (bmi >= 30 && bmi < 40)
            {
                Console.WriteLine("U heeft ernstig overgewicht");
            }
            else
            {
                Console.WriteLine("U heeft ziekelijk overgewicht");
            }
            Console.WriteLine("Gewicht/lengte = {0}", Math.Round(bmi, 1).ToString());
            Console.ReadKey();
        }
    }
}
