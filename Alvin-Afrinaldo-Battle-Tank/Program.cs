/* 
Alvin Afrinaldo - 2207113382
Teknik Informatika B 
*/

using System;

namespace battletank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            awal();

            // variabel yg dibutuhkan
            int dessertLength = 5;
            char tank = 'T';
            char sand = '~';
            char hit = 'X';
            char miss = '0';
            int tankTotal = 3;

            // metodenya
            char[,] dessert = creatDessert(dessertLength, sand, tank, tankTotal);
            printDessert(dessert, sand, tank);

            int unknownTankDetected = tankTotal;

            while(unknownTankDetected > 0)
            {
                int[] guessCoordinates = getUserCoordinates(dessertLength);
                char locationViewUpdate = verifyGuessAndTarget(guessCoordinates, dessert, tank, sand, hit, miss);
                if(locationViewUpdate == hit)
                {
                    unknownTankDetected--;
                }
                dessert = updateDessert(dessert, guessCoordinates, locationViewUpdate);
                printDessert(dessert, sand, tank);
            }
            Console.WriteLine("\nSELAMAT!");
            Console.WriteLine("Kamu Berhasil Menemukan Semua Tanknya!");
            Console.Read();
        }
        // intro
        private static void awal()
        {
            Console.WriteLine("\nSelamat Datang di Game Battle Tank");
            Console.WriteLine("Semoga Menyenangkan!");
            Console.ReadLine();
        }
        
        private static void printDessert(char[,] dessert, char sand, char tank)
        {
            Console.Write(" ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + " ");
            }
            Console.WriteLine();

            for (int row = 0; row < 5; row++)
            {
                Console.Write(row + 1 + " ");
                for (int coloumn = 0; coloumn < 5; coloumn++)
                {
                    char position = dessert [row, coloumn];
                    if(position == tank)
                    {
                        Console.Write(sand + " ");
                    }
                    else
                    {
                        Console.Write(position + " ");
                    }     
                }
                Console.WriteLine();
            }
        }
        private static char verifyGuessAndTarget(int[] guessCoordinates, char[,] dessert, char tank, char sand, char hit, char miss)
        {
            string message;
            int row = guessCoordinates[0];
            int coloumn = guessCoordinates[1];
            char target = dessert[row, coloumn];
            if(target == tank)
            {
                message = "\nKamu menemukan tanknya!\nTank hancur!\n"; 
                target = hit;
            }
            else if(target == sand)
            {
                message = "\nKamu salah menebaknya!\nSilahkan coba lagi\n";
                target = miss;
            }
            else
            {
                message = "\nKamu sudah memilih ini\nPilih target lainnya\n";
            }
            Console.WriteLine(message);
            return target;
        }
        private static char[,] updateDessert(char[,] dessert, int[] guessCoordinates, char locationViewUpdate)
        {
            int row = guessCoordinates[0];
            int coloumn = guessCoordinates[1];
            dessert[row, coloumn] = locationViewUpdate;
            return dessert;
        }
        private static int[] getUserCoordinates(int dessertLength)
        {
            int row;
            int coloumn;

            do
            {
                Console.Write("Pilih baris yang kamu inginkan : ");
                row = Convert.ToInt32(Console.ReadLine());
            } 
            while (row < 0 || row > dessertLength + 1);

            do
            {
                Console.Write("Pilih kolom yang kamu inginkan : ");
                coloumn = Convert.ToInt32(Console.ReadLine());
            } 
            while (coloumn < 0 || coloumn > dessertLength + 1);

            return new[]{row -1, coloumn -1};
        }
        // buat array 2d
        private static char[,] creatDessert(int dessertLength, char sand, char tank, int tankTotal)
        {
            char[,] dessert = new char [dessertLength, dessertLength];
            for (int row = 0; row < dessertLength; row++)
            {
                for (int coloumn = 0; coloumn < dessertLength; coloumn++)
                {
                    dessert[row, coloumn] = sand;
                }
            }

            return placeTanks(dessert, tankTotal, sand, tank);
        }
        // taruh 3 tank dalam array
        private static char[,] placeTanks(char[,] dessert, int tankTotal, char sand, char tank)
        {
            int placedTanks = 0;
            int dessertLength = 5;

            while(placedTanks < tankTotal)
            {
                int[] tankLocation = generateTankCoordinates(dessertLength);
                char position1 = dessert[tankLocation[0], tankLocation[1]];

                if(position1 == sand)
                {
                    dessert[tankLocation[0], tankLocation[1]] = tank;
                    placedTanks++;
                }
            }
            return dessert;
        }

        // generate random position
        private static int[] generateTankCoordinates(int dessertLength)
        {
            Random rand = new Random();
            int[] coordinates = new int[3];
            for (int i = 0; i < coordinates.Length; i++)
            {
                coordinates[i] = rand.Next(dessertLength);
            }
            return coordinates;
        }
    }
}