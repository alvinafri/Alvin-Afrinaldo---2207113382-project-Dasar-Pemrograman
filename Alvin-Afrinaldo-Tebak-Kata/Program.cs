/*
Alvin Afrinaldo - 2207113382
Teknik Informatika - B
*/

using System;
using System.Collections.Generic;

namespace tebakkata
{
    class Program
    {
        static int kesempatan = 5;
        static string kataMisteri = "runtuh";
        static List<string> listTebakan = new List<string>{};

        static void Main(string[] args)
        {
            Awal();
            Mulai();
            Akhir();
        }

        static void Awal()
        {
            Console.WriteLine("Selamat Datang diPermainan Tebak Kata");
            Console.WriteLine($"Kamu mempunyai {kesempatan} kesempatan untuk menebak");
            Console.WriteLine("Petunjuknya kata ini adalah judul lagu Feby Putri ");
            Console.WriteLine($"Kata tersebut terdiri dari {kataMisteri.Length} huruf");
            Console.WriteLine("Kata apakah itu?");
            Console.WriteLine("Tekan enter untuk mulai");
            Console.ReadKey();
            Console.WriteLine();
        }
        
        static void Mulai()
        {
            while (kesempatan > 0)
            {
                Console.Write("Apa huruf tebakanmu? : ");
                string masukann = Console.ReadLine();
                listTebakan.Add(masukann);

                if(CekJawaban(kataMisteri,listTebakan))
                {
                    Console.WriteLine("Selamat kamu berhasil menebak katanya");
                    Console.WriteLine($"Kata misteri hari ini adalah {kataMisteri}");
                    break;
                }
                else if(kataMisteri.Contains(masukann))
                {
                    Console.WriteLine("Huruf itu ada di dalam kata ini");
                    Console.WriteLine("Tebak huruf lainnya...");
                    Console.WriteLine(CekHuruf(kataMisteri, listTebakan));
                }
                else
                {
                    Console.WriteLine("Huruf itu tidak ada di dalam kata ini");
                    kesempatan--;
                    Console.WriteLine($"Kesempatan kamu tersisa {kesempatan}");
                }
                
                if(kesempatan == 0)
                {
                    Akhir();
                    break;
                }
            }
        }
        static bool CekJawaban(string kataRahasia, List<string> list)
        {
            bool status = false;
            for (int i = 0; i < kataRahasia.Length; i++)
            {
                string c = Convert.ToString(kataRahasia[i]);
                if(list.Contains(c))
                {
                    status = true;
                }
                else{
                    return status = false;
                }
            }
            return status;
        }
        static string CekHuruf(string kataRahasia, List<string> list)
        {
            string x = "";

            for (int i = 0; i < kataRahasia.Length; i++)
            {
                string c = Convert.ToString(kataRahasia[i]);
                if(list.Contains(c))
                {
                    x = x + c;
                }
                else{
                    x = x+ "-";
                }
            }
            return x;
        }
        static void Akhir()
        {
            Console.WriteLine("Permainan berakhir");
            Console.WriteLine($"Kata misteri sebenarnya adalah {kataMisteri}");
            Console.WriteLine("Terima kasih telah berusaha!");
        }

    }
}