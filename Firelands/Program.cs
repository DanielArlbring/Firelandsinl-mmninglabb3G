using System;

namespace nextGame
{
    public class Program
    {
        public static bool mainLoop = true;
        public static Player currentPlayer = new Player();

        static void Main(string[] args)


        {
            bool condition = true;
            while (condition)
            {
                Start();
                condition = false;
                Bosses.FirstBoss();
                while (mainLoop)
                {
                    Bosses.Baleroc();
                    Bosses.Shannox();
                    Bosses.Ragnaros();
                    Bosses.LichKing();
                }

                static void Start()
                {
                    Console.WriteLine("Welcome to the game...");
                    Console.WriteLine("===========================");
                    Console.WriteLine("Press enter to continue");
                    Console.WriteLine("===========================");
                    string input = Console.ReadLine();
                    Console.Clear();
                    string option = Console.ReadLine();
                }
            }
        }
    }
}
