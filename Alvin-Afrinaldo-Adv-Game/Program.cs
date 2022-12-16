// ALVIN AFRINALD0 - 2207113382
// TEKNIK INFORMATIKA - B

using System;

namespace advGAME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!Welcome to the Adventure Game!!");
            Console.WriteLine("What your name? [INSERT HERE]");
            Novice player = new Novice();
            player.Name = Console.ReadLine();

            Console.WriteLine("Hello " +player.Name+ "!! Are u ready to play this game?? [YES OR NO?]");
            string ifReady = Console.ReadLine(); 
            if (ifReady == "YES")
            {
                Console.WriteLine("Welcome " +player.Name+ "!! to Mario bros world");
                Enemy enemy1 = new Enemy ("Mushters");
                Console.WriteLine(player.Name+ " encountering " +enemy1.Name+ " ........");
                Console.WriteLine(enemy1.Name+ " attacking you!!!!!!");
                Console.WriteLine("Choose an action : ");
                Console.WriteLine("1. Basic Attack");
                Console.WriteLine("2. Swing Attack");
                Console.WriteLine("3. Defend");
                Console.WriteLine("4. Runaway");

                while(!player.IsDead && !player.IsRunningAway && !enemy1.IsDead)
                {
                string playerAction = Console.ReadLine();
                switch (playerAction)
                {
                    case "1" :
                    Console.WriteLine(player.Name+ " doing Basic Attack");
                    enemy1.GetHit(player.AttackPower);
                    player.Experience += 0.2f;
                    enemy1.Attack(enemy1.AttackPower);
                    player.GetHit(enemy1.AttackPower);
                    Console.WriteLine("PLAYER HEALTH : " +player.Health);
                    Console.WriteLine("ENEMY HEALTH : " +enemy1.Health +"\n");
                    break;

                    case "2" :
                    Console.WriteLine(player.Name+ " doing Swing Attack");
                    player.Swing();
                    player.Experience += 0.5f;
                    enemy1.GetHit(player.AttackPower);
                    Console.WriteLine("PLAYER HEALTH : " +player.Health);
                    Console.WriteLine("ENEMY HEALTH : " +enemy1.Health+ "\n");
                    break;

                    case "3" :
                    player.Rest();
                    Console.WriteLine("ENERGYYY RESTORED!!");
                    enemy1.Attack(enemy1.AttackPower);
                    player.GetHit(enemy1.AttackPower);
                    break;

                    case "4" :
                    Console.WriteLine(player.Name+ " Is Running away");
                    player.RunningAway();
                    break;
                    }
                }
                Console.WriteLine(player.Name+ " get " +player.Experience+ " experience point!!");
            }
            else
            {
                Console.WriteLine("Bye!!");
                Console.Read();
            }
        }     
    } 
    class Novice
    {
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public string Name { get; set; }
        public bool IsDead { get; set; }
        public bool IsRunningAway { get; set; }
        public float Experience { get; set; }
        Random rand = new Random();

        public Novice()
        {
            Health = 100;
            AttackPower = 2;
            SkillSlot = 1;
            IsDead = false;
            Experience = 0f;
            Name = "Newbie";
        }

        public void Swing()
        {
            if (SkillSlot > 0)
            {
                Console.WriteLine("!!!SWING!!!");
                AttackPower = AttackPower + rand.Next(3,11);
                SkillSlot--;
            }
            else
            {
                Console.WriteLine("OH NO, Not enough energy to use this skill");
            }
        }

        public void GetHit (int hitValue)
        {
            Console.WriteLine(Name+ " Get Hit by " +hitValue);
            Health = Health - hitValue;

            if(Health <= 0)
            {
                Health = 0;
                Die();
            }
        }

        public void Rest()
        {
            SkillSlot = 3;
            AttackPower = 1;
        }

        public void Die()
        {
            Console.WriteLine("!!!GAME OVER!!!");
            IsDead = true;
        }

        public void RunningAway()
        {
            IsRunningAway = true;
        }
    }
    class Enemy
    {
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public string Name { get; set; }
        public bool IsDead { get; set; }
        Random rand = new Random();

        public Enemy(string name)
        {
            Health = 50;
            Name = name;
        }

        public void Attack(int damage)
        {
            AttackPower = rand.Next(1,10);
        }

        public void GetHit(int hitValue)
        {
            Console.WriteLine(Name+ " Get Hit by " +hitValue);
            Health = Health - hitValue;

            if(Health <= 0)
            {
                Health = 0;
                Die();
            }
        }

        public void Die()
        {
            Console.WriteLine(Name+ " is Dead");
            IsDead = true;
        }
    }
}

