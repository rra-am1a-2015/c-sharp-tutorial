using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_ClassesPart5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 16 Classes Part 5";

            /* 
            1) Maak een class Laptop in een apart bestand Laptop.cs. Zorg ervoor dat deze in dezelfde namespace
            2) Maak voor deze class tenminste 8 Fields.
            3) Maak voor deze Fields Properties (get en set)
            4) Maak tenminste de default constructor, een constructor die alle Fields initialiseert en een constructor
                die 3 Fields initialiseert
            5) Maak een method genaamd ShowLaptops die alle waarden van de Fields kan weergeven.
            6) Maak een array die Laptop objecten kan bevatten. 
            7) Vul het array met 5 Laptop objecten.
            8) beeld de objecten af in de console met een for - loop. Roep daarvoor de method ShowLaptops aan
            9) Schrijf de objecten naar een tekstbestand. (Zie lesson 22 Rb whitaker)
            */
            Laptop[] mijnLaptop;
            mijnLaptop = new Laptop[]
            {
                new Laptop("HP", 11, "AMD", 4, "1366x768", false, video.INTEL_HD_GRAPHICS, false),
                new Laptop("DELL", 14, "INTEL", 8, "1920x1080", true, video.NVIDIA_QUATRO, true),
                new Laptop("MSI", 32, "HAKTO", 16, "10366x1768", true, video.NVIDIA_TEGRA, false)
            };

            for (int i = 0; i < mijnLaptop.Length; i++)
            {
                mijnLaptop[i].ShowLaptops();
            }

            string output = "" + Directory.GetCurrentDirectory() + "\r\n";
            for ( int i = 0; i < mijnLaptop.Length; i++)
            {
                output += mijnLaptop[i].ShowLaptopsToText();
            }

            File.WriteAllText(@"c:\test\test.txt", output);
            
            Console.ReadKey();
        }
    }
}
