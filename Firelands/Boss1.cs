using System;
using System.Collections.Generic;
using System.Text;

namespace nextGame
{
    public class Bosses
    {
        static Random rand = new Random();
        public static void FirstBoss()
        {
            Console.Clear();
            Console.WriteLine("Beth'thilac");
            Console.ReadKey();
            Combat(false, "Beth'thilac", 4, 4);
            Console.WriteLine("Congratulations you've gained 10xp");
            Console.ReadKey();
        }
        public static void Baleroc()
        {
            Console.Clear();
            Console.WriteLine("Baleroc");
            Console.ReadKey();
            Combat(true, "", 4, 4);
            Console.WriteLine("Congratulations, you've gained 10xp");
            Console.ReadKey();
        }
        public static void Shannox()
        {
            Console.Clear();
            Console.WriteLine("Shannox");
            Console.ReadKey();
            Combat(false, "Shannox", 4, 2);
            Console.WriteLine("Congratulations, you've gained 20 xp");
            Console.ReadKey();
        }
        public static void Ragnaros()
        {
            Console.Clear();
            Console.WriteLine("Ragnaros");
            Console.ReadKey();
            Combat(false, "Ragnaros", 4, 2);
            Console.ReadKey();
        }

        public static void LichKing()
        {
            Console.Clear();
            Console.WriteLine("EXTRA BOSS, Lich King");
            Console.ReadKey();
            Combat(false, "LichKing", 4, 2);
            Console.WriteLine("Congratulations, you've beat the game you are now level 2");
            Console.ReadKey();
            System.Environment.Exit(0);
        }




        public static void firstBoss()
        {
            switch (rand.Next(0, 4))
            {
                case 0:
                    Baleroc();
                    break;
                case 1:
                    Shannox();
                    break;
                case 2:
                    Ragnaros();
                    break;
                case 3:
                    LichKing();
                    break;
            }
        }




        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {

                p = rand.Next(1, 5);
                h = rand.Next(1, 8);

            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while (h > 0)
            {
                Console.WriteLine("==================");
                Console.WriteLine("| (A)ttack |");
                Console.WriteLine("| (H)eal   |"); 
                Console.WriteLine("===================");
                Console.WriteLine("Health" + Program.currentPlayer.health);
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //Attack
                    Console.WriteLine("You attack the boss, but the monster strikes you back " + n + " ");
                    int damage = p - Program.currentPlayer.health;
                    if (damage < 2)
                        damage = 10;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);
                    Console.WriteLine("You loose " + damage + " health and deal " + attack + " damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                    Console.ReadKey();
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    if (Program.currentPlayer.potion == 0)
                    {
                        Console.WriteLine("Use Health pot");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("The " + n + " strikes you agian and you loose " + damage + " health");
                    }
                    else
                    {
                        Console.WriteLine("You reach into your pocket and you find a shiny drink");
                        int potionV = 5;
                        Console.WriteLine("You gain " + potionV + " health");
                        Program.currentPlayer.health += potionV;
                        int x = Program.currentPlayer.GetXP();
                        Console.WriteLine("You stand victorious, you gain " + x + " XP! ");
                        Program.currentPlayer.exp += x;

                        if (Program.currentPlayer.CanLevelUp())
                            Program.currentPlayer.LevelUp();
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}


