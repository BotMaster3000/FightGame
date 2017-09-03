using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightGame.Creatures
{
    public class Player : CreatureBase
    {
        public int experience = 0;
        public int level = 0;
        public int stamina = 100;

        public Player(string playerName)
        {
            health = 100;
            damage = 5;
            defense = 5;
            name = playerName;
        }
    }
}
