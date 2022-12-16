/*
Alvin Afrinaldo - 2207113382
Teknik Informatika - B
*/

using System;

namespace DasPro
{
    class Program
    {
        //Class random
        static Random rand = new Random();

        //Deklarasi variable
        static int level = 1;
        static int kodeA;
        static int kodeB;
        static int kodeC;

        static int hasilTambah;
        static int hasilTambah2;
        static int hasilTambah3;

        static int hasilKali;
        static int hasilKali2;
        static int hasilKali3;

        static int tebakanA = 0;
        static int tebakanB = 0;
        static int tebakanC = 0;

        static int kesempatan = 3;
        static bool bGameStart;

        static void Init()
        {
            //Operasi Aritmatika
            kodeA = rand.Next(1, 2*level);
            kodeB = rand.Next(1, 2*level);
            kodeC = rand.Next(1, 2*level);

            hasilTambah = kodeA+kodeB+kodeC;
            hasilTambah2 = kodeA+kodeB;
            hasilTambah3 = kodeB+kodeC;
        
            hasilKali = kodeA*kodeB*kodeC;
            hasilKali2 = kodeA*kodeB;
            hasilKali3 = kodeB*kodeC;
        }

        static void Awal()
        {
            Init();
            //Kata yang muncul ketika dimulai
            Console.WriteLine("-----------------------Selamat Datang------------------------------");
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("-------------------------------------------------------------------");
        }

        static void PlayGame()
        {
            Console.WriteLine("level "+level);
            Console.WriteLine(" ");
            Console.WriteLine("Password terdiri dari 3 angka");
            Console.WriteLine(" ");
            Console.WriteLine("Hasil semua kode jika ditambahkan adalah "+hasilTambah);
            Console.WriteLine("Hasil semua kode jika dikalikan adalah "+hasilKali);
            Console.WriteLine("Jika kode 1 dan kode 2 ditambahkan hasilnya "+hasilTambah2);
            Console.WriteLine("Jika kode 1 dan kode 2 dikalikan hasilnya "+hasilKali2);
            Console.WriteLine("Jika kode 2 dan kode 3 ditambahkan hasilnya "+hasilTambah3);
            Console.WriteLine("Jika kode 2 dan kode 3 dikalikan hasilnya "+hasilKali3);
            Console.WriteLine(" ");
            Console.Write("Masukkan kode pertama : ");
            tebakanA = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Masukkan kode kedua : ");
            tebakanB = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Masukkan kode ketiga : ");
            tebakanC = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Tebakan anda "+tebakanA+" "+tebakanB+" "+tebakanC+" ?");
            
            if(tebakanA == kodeA && tebakanB == kodeB && tebakanC == kodeC)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Tebakan kamu benar...");
                level ++;
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Tebakan kamu salah...");
                kesempatan --;
                Console.WriteLine("Sisa Kesempatan anda "+kesempatan);
                Console.WriteLine("Tekan enter untuk lanjut");
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void Berakhir()
        {
            Console.Clear();
            if(kesempatan == 0)
            {
                Console.WriteLine("PASSWORD SALAH");
                Console.WriteLine("!! PENYUSUP TERDETEKSI !!");
                Console.WriteLine("Tekan enter untuk keluar");
                Console.ReadLine(); bGameStart = false;
            }
        }
        static void Menang()
        {
            Console.WriteLine("PASSWORD BENAR");
            Console.WriteLine("Silahkan masuk...");
            Console.ReadLine(); bGameStart = false;
        }

        //Main method
        static void Main(string[] args)
        {
            bGameStart = true;
            while(bGameStart)
            {
                Awal();
                if(kesempatan > 0)
                {
                    if(bGameStart==true)
                    {
                    PlayGame();
                    }
                    if(level == 6)
                {
                    Menang();
                }
                    Console.Clear();
                }
                else
                {        
                    Berakhir();
                    Console.Clear();
                }    
            }
            Console.Write("\nTekan Enter untuk keluar..."); Console.ReadKey();
        }
        
    }
} 
