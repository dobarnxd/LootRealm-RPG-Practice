using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(0, -1, "Home", "This is your house", "Home.png");
            newWorld.AddLocation(-1, -1, "Farmer's House", "There are rows of corn growing here, with giant rats hiding between them.", "Farmhouse.png");
            newWorld.AddLocation(-2, -1, "Farmer's Field", "This is your house", "FarmFields.png");
            newWorld.AddLocation(-1, 0, "Trading Shop", "The shop of Susan, the trader.", "Trader.png");
            newWorld.AddLocation(0, 0, "Town square", "You see a fountain here.", "TownSquare.png");
            newWorld.AddLocation(1, 0, "Town Gate", "There is a gate here, protecting the town from giant spiders.", "TownGate.png");
            newWorld.AddLocation(2, 0, "Spider Forest", "The trees in this forest are covered with spider webs.", "SpiderForest.png");
            newWorld.AddLocation(0, 1, "Herbalist's hut", "You see a small hut, with plants drying from the roof.", "HerbalistsHut.png");
            newWorld.AddLocation(0, 2, "Herbalist's garden", "There are many plants here, with snakes hiding behind them.", "HerbalistsGarden.png");
            return newWorld;
        }
    }
}
