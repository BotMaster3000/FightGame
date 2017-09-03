using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightGame.Map;
using FightGame.Creatures;
using FightGame.Actions;

namespace FightGame.Logic
{
    public class GameHandler
    {
        public WorldMap map = new WorldMap();
        public Player player;
        public Location currentLocation;
        public List<InteractionAction> currentPossibleActions = new List<InteractionAction>();

        private void InitializePlayer()
        {
            try
            {
                Console.WriteLine("Choose a name for your Adventurer:");
                player = new Player(Console.ReadLine());
            }
            catch
            {

            }
        }
        private bool SetCurrentLocation(string locationName)
        {
            bool locationFound = false;
            foreach(Location location in map.locations)
            {
                if(location.name == locationName)
                {
                    currentLocation = location;
                    locationFound = true;
                }
            }
            return locationFound;
        }
        private void HandleChangeLocation()
        {
            Console.WriteLine("Choose Location:");

            foreach(Location location in currentLocation.connectedLocations)
            {
                Console.WriteLine(location.name);
            }
            Console.WriteLine("Stay");
            while (true)
            {
                string locationToGo = Console.ReadLine();

                if (locationToGo == "Stay" || SetCurrentLocation(locationToGo))
                {
                    return;
                }
                Console.WriteLine("Not a valid Location");
            }
        }
        private void HandleFightMonsters()
        {
            List<CreatureBase> monsterList = new List<CreatureBase>();
            /*
             * TODO: IMPLEMENT FIGHT MONSTERS
             */
        }
        private void HandleBuyFromShop()
        {
            /*
             * TODO: IMPLEMENT BUY FROM SHOP
             */
        }
        private void HandleSleep()
        {
            /*
             * TODO: IMPLEMENT SLEEP
             */
        }
        private void HandlePlayerActions()
        {
            Console.Clear();
            Console.WriteLine("You are currently at: {0}", currentLocation.name);

            Console.WriteLine("Choose an action");
            int counter = 1;
            foreach(InteractionAction action in currentLocation.possibleActions)
            {
                Console.WriteLine(counter + ": " + action.name);
                ++counter;
            }
            try
            {
                int userOption = Convert.ToInt32(Console.ReadLine());
                switch (currentLocation.possibleActions[userOption-1].name)
                {
                    case "Change Location":
                        HandleChangeLocation();
                        break;
                    case "Fight Monsters":
                        HandleFightMonsters();
                        break;
                    case "Buy from Shop":
                        HandleBuyFromShop();
                        break;
                    case "Sleep":
                        HandleSleep();
                        break;
                }
            }
            catch { }
        }
        public GameHandler()
        {
            InitializePlayer();
            SetCurrentLocation("Home");

            while(player.health > 0)
            {
                HandlePlayerActions();
            }
            Console.WriteLine("Rest in War, {0}", player.name);
        }
    }
}
