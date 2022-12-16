// ALVIN AFRINALDO - 2207113382
// TEKNIK INFORMATIKA - B
// UTS - NO 4

using System;
using System.Text.RegularExpressions;

namespace PasswordGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string teks, hasilenkripsi = " ";
            string huruf = "abcdefghijklmnopqrstuvwxyzabcABCDEFGHIJKLMNOPQRSTUVWXYZABC";
            Regex reg = new Regex ("[^A-Za-z]");

            do
            {
                Console.WriteLine("TEKS : ");
                teks = Console.ReadLine();
            } while (String.IsNullOrEmpty(teks) || reg.IsMatch(teks));
            
            foreach (Char t in teks)
            {
                Char temp = ' ';

                for (int i = 0; i < huruf.Length; i++)
                {
                    Char c = huruf[i];

                    if (t.Equals(c))
                    {
                        temp = huruf[i+3];
                        break;
                    }

                    else if (t.Equals(' '))
                    {
                        temp = ' ';
                        break;
                    }
                }
                hasilenkripsi = hasilenkripsi + temp;            
            }
            Console.WriteLine ("ENKRIPSI : " + hasilenkripsi);
        }
    }
}