using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace nextGame
{

    public class Player
    {
        Random rand = new Random();
        public string name;
        public int health = 100;
        public int damage = 5;
        public int exp = 0;
        public int armorValue;
        public int weaponValue = 1;
        public int potion = 5;
        public int lvl = 1;
        public int mods = 0;
        public int GetXP()
        {
            int upper = (20 * mods + 50);
            int lower = (15 * mods + 10);
            return rand.Next(lower, upper);
        }

        public int GetLevelUpValue()
        {
            return 100 * lvl + 400;
        }

        public bool CanLevelUp()
        {
            if (exp >= GetLevelUpValue())
                return true;
            else
                return false;
        }

        public void LevelUp()
        {
            while (CanLevelUp())
            {
                exp -= GetLevelUpValue();
                lvl++;
            }
            Console.WriteLine("Congratulations! You are now level " + lvl + " ");
        }
    }
}
