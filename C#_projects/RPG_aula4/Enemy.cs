using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_aula4
{
    class Enemy
    {
        public string name { get; set; }
        public int life { get; set; }
        public int XP { get; set; }
        public int attack { get; set; }

        public Enemy(string name, int life, int attack)
        {
            this.name = name;
            this.life = life;
            this.attack = attack;
            this.XP = life + attack;
        }
    }
}
