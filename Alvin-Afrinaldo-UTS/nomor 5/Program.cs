// ALVIN AFRINALDO - 2207113382
// TEKNIK INFORMATIKA - B
// UTS - NO 5

using System;
using System.IO;
using System.Collections.Generic;

namespace HangmanTebakKata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tebakan = new List<string>{};
            Random rand = new Random();
            int kesempatan = 10;
            int RNG = rand.Next(0, 10);
            string [] text = File.ReadAllLines("kata.txt");
            string kata = text[RNG];
           
            Console.WriteLine("Selamat Datang di Game Tebak Kata");
            Console.WriteLine("Kata ini terdiri atas "+text.Length+"huruf");
            Console.WriteLine("Anda memiliki 10 kesempatan untuk menebak kata");
            Console.WriteLine("Selamat Bermain!");

            while (true)
            {
                Console.WriteLine("HURUF TEBAKAN : ");
                string iUser = Console.ReadLine();
                Console.Clear();

                tebakan.Add(iUser);

                if (CekKata(kata, tebakan))
                {
                    Console.WriteLine("Kata adalah "+kata);
                    break;
                }
                else if (kata.Contains(iUser))
                {
                    Console.WriteLine("Tebakan benar");
                    Console.WriteLine(CekHuruf(kata, tebakan));
                }
                else
                {
                    Console.WriteLine("Tebakan salah");
                    kesempatan = kesempatan--;
                
                    if (kesempatan == 9)
                    {
                        Console.WriteLine("__|__");
                    }

                    if (kesempatan == 8)
                    {   
                        Console.WriteLine("  |  ");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("__|__");
                    }

                    if (kesempatan == 7)
                    {   
                        Console.WriteLine("  |/  ");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("__|__");
                    }

                    if (kesempatan == 6)
                    {   
                        Console.WriteLine("___________");
                        Console.WriteLine("  |/  ");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("__|__");
                    }

                    if (kesempatan == 5)
                    {   
                        Console.WriteLine("___________");
                        Console.WriteLine("  |/      |");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("__|__");
                    }

                    if (kesempatan == 4)
                    {   
                        Console.WriteLine("___________");
                        Console.WriteLine("  |/      |");
                        Console.WriteLine("  |      (_)");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("__|__");
                    }

                    if (kesempatan == 3)
                    {   
                        Console.WriteLine("___________");
                        Console.WriteLine("  |/      |");
                        Console.WriteLine("  |      (_)");
                        Console.WriteLine("  |      /|/");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("__|__");
                    }

                    if (kesempatan == 2)
                    {   
                        Console.WriteLine("___________");
                        Console.WriteLine("  |/      |");
                        Console.WriteLine("  |      (_)");
                        Console.WriteLine("  |      /|/");
                        Console.WriteLine("  |       |");
                        Console.WriteLine("  |  ");
                        Console.WriteLine("__|__");
                    }

                    if (kesempatan == 1)
                    {   
                        Console.WriteLine("___________");
                        Console.WriteLine("  |/      |");
                        Console.WriteLine("  |      (_)");
                        Console.WriteLine("  |      /|/");
                        Console.WriteLine("  |       |");
                        Console.WriteLine("  |      // ");
                        Console.WriteLine("__|__");
                    }

                    if (kesempatan == 0)
                    {   
                        Console.WriteLine("Maaf anda gagal");
                        break; 
                    }
            }
        }
    }

        static string CekHuruf(string text, List<string> tebakan1)
        {
            string display = " ";
            for (int i = 0; i < text.Length; i++)
            {
                string e = Convert.ToString(text[i]);
                if (tebakan1.Contains(e))
                {
                    display += e;
                }
                else
                {
                    display += '*';
                }
            }
            return display;
        }
        static bool CekKata(string text, List <string> tebakan1)
        {
            bool g = false;
            for (int i = 0; i < text.Length; i++)
            {
                string e = Convert.ToString(text[i]);
                if(tebakan1.Contains(e))
                {
                    g = true;
                }
                else
                {
                    return g = false;            
                }
            }
            return g;
        }
    }
}