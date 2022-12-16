/*
Alvin Afrinaldo - 2207113382
*/
using System;

namespace DasPro
{
    class Program
    {
        //Main Method
        static void Main(string[] args)
        {
            //Deklarasi Variabel
            const int a = 7;
            const int b = 5;
            const int c = 2; 
            int hasilTambah = a+b+c;
            int hasilKali = a*b*c;
            int hasilKurang = a-b-c;
            int hasilBagi = a/b/c;

            //Menuliskan Narasi
            Console.WriteLine("Hello World!");
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("- Password terdiri dari 4 angka");
            Console.WriteLine("- Jika ditambahkan hasilnya "+hasilTambah);
            Console.WriteLine("- Jika dikalikan hasilnya "+hasilKali);
            Console.WriteLine("- Jika dikurangkan hasilnya "+hasilKurang);
            Console.WriteLine("- Jika dibagi hasilnya "+hasilBagi);
            Console.WriteLine("");
            Console.Write("Enter code :");
        }
    }
}