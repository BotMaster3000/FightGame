using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightGame.Actions;

namespace FightGame.Map
{
    public class Location
    {
        public string name;
        public List<Location> connectedLocations = new List<Location>();
        public List<InteractionAction> possibleActions = new List<InteractionAction>();

        public Location(string locationName)
        {
            name = locationName;
        }
    }
}
