/* 
Alvin Afrinaldo - 2207113382
Teknik Informatika - B
*/

using System;

namespace MyApp 
{
    class Program
    {
        static Random andom = new Random();
        static int daducom;
        static int dadukita;
        static int compoin = 0;
        static int kitapoin = 0;
        static int i = 1;
         static void Main(string[] args)
        {
            Awal();
            for (int i = 1; i <= 10; i++)
            {
                Mulai();
            }
            Akhir();
            Console.ReadKey();
        }
        static void Awal()
        {
            Console.WriteLine("Pada game ini anda dan komputer akan bermain 10 ronde");
            Console.WriteLine("Setiap putaran dadu akan dilempar menghasilkan nilai tertentu");
            Console.WriteLine("Nilai dadu tertinggi akan menjadi pemenang ronde tersebut");
            Console.WriteLine("Siapa yang akan menang? Selamat berjuang");
            Console.WriteLine("\nMulai main...");
            Console.ReadLine();
        }
        static void Init()
        {
            daducom = andom.Next(1, 7);
            dadukita = andom.Next(1, 7);
        }
        static void Mulai()
        {
            Init();
            Console.WriteLine("Ronde "+i++);
            Console.WriteLine(" ");
            Console.WriteLine("Nilai komputer : "+daducom);
            Console.WriteLine("Lempar dadu anda...");
            Console.WriteLine("Nilai anda : "+dadukita);

            if(daducom > dadukita)
            {
                compoin++;
                Console.WriteLine("Komputer memenangkan babak ini.");
            }
            else if(dadukita > daducom)
            {
                kitapoin++;
                Console.WriteLine("Anda memenangkan ronde ini");
            }
            else
            {
                Console.WriteLine("DRAW!");
            }
            Console.WriteLine("- Skor kamu : "+kitapoin+ " - Skor komputer : "+compoin+".");
            Console.WriteLine("Tekan enter untuk lanjut ke ronde selanjutnya...");
            Console.ReadLine();
        }
        static void Akhir()
        {
            Console.WriteLine("Game berakhir");
            Console.WriteLine("Skor akhir kamu : "+kitapoin+" Skor akhir komputer : "+compoin+".");
            if(compoin > kitapoin)
            {
                Console.WriteLine("Sayang sekali, kamu kalah :(");
            }
            else if(kitapoin > compoin)
            {
                Console.WriteLine("Selamat kamu memenangkan game ini :)");
            }
            else
            {
                Console.WriteLine("Maaf, Tidak ada pemenang dalam game kali ini");
            }
        }
    }
}