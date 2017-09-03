using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightGame.Creatures
{
    public static class Monsters
    {
        private static CreatureBase GetCreature(int creatureHealth, string creatureName, int creatureDamage, int creatureDefense)
        {
            return new CreatureBase()
            {
                health = creatureHealth,
                name = creatureName,
                damage = creatureDamage,
                defense = creatureDefense
            };
        }
        public static CreatureBase Goblin()
        {
            return GetCreature(10, "Goblin", 5, 1);
        }
        public static CreatureBase Snake()
        {
            return GetCreature(5, "Snake", 1, 1);
        }
    }
}
