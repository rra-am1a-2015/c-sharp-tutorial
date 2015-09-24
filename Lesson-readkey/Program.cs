using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_readkey
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.Title = "Lesson ReadKey()";

            Console.Write("Druk een letter in van het toetsenbord: ");

            ConsoleKeyInfo invoer = Console.ReadKey();

            Console.WriteLine("");

            while (invoer.KeyChar != 'S')
            {
                
                Console.WriteLine("\nU heeft {0} ingedrukt en niet de S.", invoer.KeyChar);

                Console.Write("\nAls u wilt stoppen druk dan op de letter S: ");
                invoer = Console.ReadKey();
            }

            Console.WriteLine("\nU heeft de S gekozen. Het spel is gestopt");

            Console.ReadKey();
        }
    }
}
