using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_ClassesPart5
{
    public enum video { AMD_RADEON, INTEL_HD_GRAPHICS, NVIDIA_GEFORCE, NVIDIA_QUATRO, NVIDIA_TEGRA }

    public class Laptop
    {
        // Fields
        private string brand;
        private float displayDiagonal;
        private string processor;
        private int internalMemory;
        private string resolution;
        private bool dvdPlayer;
        private video card;
        private bool touchScreen;
        
        //Properties
        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }
        public float DisplayDiagonal
        {
            get { return this.displayDiagonal; }
            set { this.displayDiagonal = value; }
        }
        public string Processor
        {
            get { return this.processor; }
            set { this.processor = value; }
        }
        public int InternalMemory
        {
            get { return this.internalMemory; }
            set { this.internalMemory = value; }
        }
        public string Resolution
        {
            get { return this.resolution; }
            set { this.resolution = value; }
        }
        public bool DvdPlayer
        {
            get { return this.dvdPlayer; }
            set { this.dvdPlayer = value; }
        }
        public video Card
        {
            get { return this.card; }
            set { this.card = value; }
        }
        public bool TouchScreen
        {
            get { return this.touchScreen; }
            set { this.touchScreen = value; }
        }

        
        // Constructors
        public Laptop()
        {

        }

        public Laptop(string brand, int internalMemory, string resolution)
        {
            this.brand = brand;
            this.internalMemory = internalMemory;
            this.resolution = resolution;
        }

        public Laptop(string brand, float displayDiagonal, string processor, int internalMemory,
                        string resolution, bool dvdPlayer, video card, bool touchScreen)
        {
            this.brand = brand;
            this.displayDiagonal = DisplayDiagonal;
            this.processor = processor;
            this.internalMemory = internalMemory;
            this.resolution = resolution;
            this.dvdPlayer = dvdPlayer;
            this.card = card;
            this.touchScreen = touchScreen;
        }

        // Methods
        public void ShowLaptops()
        {
            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++\n" +
                              "Het merk is:\t\t\t{0}\n" +
                              "De schermdiagonaal is:\t\t{1}\n" +
                              "De processor is:\t\t{2}\n" +
                              "Intern geheugen grootte\t\t{3}\n" +
                              "De max resolutie is:\t\t{4}\n" +
                              "DVD speler aanwezig:\t\t{5}\n" +
                              "Videokaarttype:\t\t\t{6}\n" +
                              "Touchscreen aanwezig:\t\t{7}\n" +
                              "++++++++++++++++++++++++++++++++++++++++++++++\n",
                              this.brand,
                              this.displayDiagonal,
                              this.processor,
                              this.internalMemory,
                              this.resolution,
                              this.booleanTranslator(this.dvdPlayer),
                              this.card,
                              this.booleanTranslator(this.touchScreen)
                              );
        }

        public string ShowLaptopsToText()
        {
           string text = String.Format("\n++++++++++++++++++++++++++++++++++++++++++++++\r\n" +
                                        "Het merk is:\t\t\t{0}\r\n" +
                                        "De schermdiagonaal is:\t\t{1}\r\n" +
                                        "De processor is:\t\t{2}\r\n" +
                                        "Intern geheugen grootte\t\t{3}\r\n" +
                                        "De max resolutie is:\t\t{4}\r\n" +
                                        "DVD speler aanwezig:\t\t{5}\r\n" +
                                        "Videokaarttype:\t\t\t{6}\r\n" +
                                        "Touchscreen aanwezig:\t\t{7}\r\n" +
                                        "++++++++++++++++++++++++++++++++++++++++++++++\r\n",
                                        this.brand,
                                        this.displayDiagonal,
                                        this.processor,
                                        this.internalMemory,
                                        this.resolution,
                                        this.booleanTranslator(this.dvdPlayer),
                                        this.card,
                                        this.booleanTranslator(this.touchScreen)
                                        );
            return text;
        }

        public static void writeToTextFile(Laptop[] laptopArray)
        {
            string output = "";
            for (int i = 0; i < laptopArray.Length; i++)
            {
                output += laptopArray[i].ShowLaptopsToText();
            }

            string targetDirectory = Directory.GetCurrentDirectory() + @"\output";
            Directory.CreateDirectory(targetDirectory);
            File.WriteAllText(targetDirectory + @"\test.txt", output);
        }

        private string booleanTranslator(bool trueFalse)
        {
            if (trueFalse)
            {
                return "ja";
            }   
            else
            {
                return "nee";
            }
        }

    }
}
