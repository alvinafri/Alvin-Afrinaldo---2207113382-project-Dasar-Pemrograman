// ALVIN AFRINALDO - 2207113382
// TEKNIK INFORMATIKA - B
// UTS - NO 3

using System;

namespace TiketBioskop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nama;
            int tahunsekarang = 2022;
            int usia, tarif;

            Console.WriteLine("NAMA : ");
            nama = Console.ReadLine();

            Console.WriteLine("TAHUN KELAHIRAN : ");
            usia = int.Parse(Console.ReadLine());

            if(tahunsekarang - usia < 10 || tahunsekarang - usia > 60)
            {
                tarif = 10000;
            }
            else
            {
                tarif = 25000;
            }

            Console.WriteLine("|***************************|");
            Console.WriteLine("{0,-6} {1, -15} {2, 6}","|","-- STUDIO 1 --","|");
            Console.WriteLine("{0,-8} {1, 20}","|Nama:", nama+"|");
            Console.WriteLine("{0,-8} {1, -3} {2, 16}","|Harga:","Rp",tarif+"|");
            Console.WriteLine("|---------------------------|");
        }
    }
}