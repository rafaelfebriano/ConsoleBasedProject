using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class BilanganGenap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BILANGAN GENAP 1 - 50 ===\n");

            int i = 2; 
            while (i <= 50)
            {
                Console.Write($"{i} ");
                i += 2; 
            }

            Console.WriteLine("\n\nProgram selesai. Tekan ENTER untuk keluar...");
            Console.ReadLine();
        }
    }
}
