using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightGame.Actions
{
    public static class InteractionActions
    {
        public static InteractionAction ChangeLocation()
        {
            return new InteractionAction("Change Location");
        }
        public static InteractionAction FightMonsters()
        {
            return new InteractionAction("Fight Monsters");
        }
        public static InteractionAction BuyFromShop()
        {
            return new InteractionAction("Buy from Shop");
        }
        public static InteractionAction Sleep()
        {
            return new InteractionAction("Sleep");
        }
    }
}
