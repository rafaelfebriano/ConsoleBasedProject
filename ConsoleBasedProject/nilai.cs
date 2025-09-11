using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class nilai
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai: ");
            int nilai = Convert.ToInt32(Console.ReadLine());
            string predikat;

            if (nilai >= 85)
                predikat = "A";
            else if (nilai >= 70)
                predikat = "B";
            else if (nilai >= 55)
                predikat = "C";
            else if (nilai >= 40)
                predikat = "D";
            else
                predikat = "E";

            Console.WriteLine("Predikat Anda: " + predikat);
        }
    }
}
