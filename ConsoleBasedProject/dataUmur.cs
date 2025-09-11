using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class dataUmur
    {

        static void Main(string[]args)
        {
            Console.Write("Masukan Nama Anda:");
            string nama = Console.ReadLine();

            Console.Write("Masukan Umur Anda:");
            int umur = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Halo " + nama + ", umur anda adalah " + umur + " tahun.");
            Console.ReadKey();
        }
    }
}
