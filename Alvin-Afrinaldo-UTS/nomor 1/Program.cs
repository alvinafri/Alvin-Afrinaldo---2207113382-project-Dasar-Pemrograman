// ALVIN AFRINALDO - 220711382
// TEKNIK INFORMATIK - B
// UTS - NO 1

using System;

namespace NameTagTIUR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nama, nim, konsentrasi;

            Console.WriteLine("NAMA : ");
            nama = Console.ReadLine();

            Console.WriteLine("NIM : ");
            nim = Console.ReadLine();

            Console.WriteLine("KONSENTRASI : ");
            konsentrasi = Console.ReadLine();

            Console.WriteLine("|***************************|");
            Console.WriteLine("{0,-8} {1, 20}","|NAMA :",nama+"|");
            Console.WriteLine("{0,-8} {1, 20}","|",nim+"|");
            Console.WriteLine("|---------------------------|");
            Console.WriteLine("{0,-8} {1, 20}","|",konsentrasi+"|");
            Console.WriteLine("|***************************|");
        }
    }
}