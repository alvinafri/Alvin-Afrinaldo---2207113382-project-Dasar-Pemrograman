// ALVIN AFRINALDO - 2207113382
// TEKNIK INFORMATIKA - B
// UTS - NO 2

using System;

namespace PengubahMataUang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rate, usd;
            Console.WriteLine("RATE USD ke IDR");

            rate = float.Parse(Console.ReadLine());

            Console.WriteLine("JUMLAH USD : ");
            usd = float.Parse(Console.ReadLine());
            Console.WriteLine("HASIL KONVERSI : " + rate*usd);
            
        }
    }
}