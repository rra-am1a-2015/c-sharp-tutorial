using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11___for___loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lesson 11 De for loop";

            // Geef de getallen 0 t/m 10 weer

            for ( int i = 50; i >= 0; i -= 5)
            {
                Console.WriteLine(i);
            }

            // 
            


            Console.ReadKey();
        }
    }
}
