using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightGame.Actions;

namespace FightGame.Map
{
    public class WorldMap
    {
        public List<Location> locations;

        public void ConnectLocations(string location1, string location2)
        {
            Location firstLocation = null;
            Location secondLocation = null;

            foreach(Location location in locations)
            {
                if(location.name == location1)
                {
                    firstLocation = location;
                }
                if(location.name == location2)
                {
                    secondLocation = location;
                }
            }
            if(firstLocation == null || secondLocation == null)
            {
                return;
            }
            firstLocation.connectedLocations.Add(secondLocation);
            secondLocation.connectedLocations.Add(firstLocation);
        }
        public void AddActions(string locationName, List<InteractionAction> actions)
        {
            foreach (Location location in locations)
            {
                if(location.name == locationName)
                {
                    foreach(InteractionAction action in actions)
                    {
                        location.possibleActions.Add(action);
                    }
                }
            }
        }
        public WorldMap()
        {
            locations = new List<Location>()
            {
                new Location("Home"),
                new Location("TownCenter"),
                new Location("Shop"),
                new Location("Woods")
            };
            ConnectLocations("Home", "TownCenter");
            ConnectLocations("TownCenter", "Shop");
            ConnectLocations("TownCenter", "Woods");
            AddActions("Home", new List<InteractionAction>() { InteractionActions.ChangeLocation(), InteractionActions.Sleep()});
            AddActions("TownCenter", new List<InteractionAction>() { InteractionActions.ChangeLocation()});
            AddActions("Shop", new List<InteractionAction>() { InteractionActions.ChangeLocation(), InteractionActions.BuyFromShop() });
            AddActions("Woods", new List<InteractionAction>() { InteractionActions.ChangeLocation(), InteractionActions.FightMonsters() });
        }
    }
}
