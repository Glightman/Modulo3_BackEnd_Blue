using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_aula4
{
    public class Hero
    {
        public string name { get; set;}
        public int XP { get; set; }
        public int level { get; set; }
        public int life { get; set; }
        public int baseAttack { get; set; }
        public int attack { get; set; }
        public Hero(string name)
        {
            Random random = new Random();
            this.name = name;
            this.XP = 0;
            this.level = 1;
            this.life = 10;
            this.baseAttack = random.Next(1, 11);
            this.attack = this.baseAttack;    
        }

        public void GetXP(int exp)
        {
            XP += exp;
            int newLevel = (XP / 10) + 1;
            if (newLevel > level)
            {
                Console.WriteLine("VOCÊ SUBIU DE NÍVEL!");
                life = newLevel * 10;
            }
            level = newLevel;
            attack = baseAttack + level;
        }
    }

    
}

