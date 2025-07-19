using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession
    {
        private Player _currentPlayer;
        private Location _currentLocation;
        private World _currentWorld;
        private WorldFactory _newWorldFactory;

        public GameSession()
        {
            _currentPlayer = new Player("Scott", PlayerClass.Warrior);
            _newWorldFactory = new WorldFactory();
            _currentWorld = _newWorldFactory.CreateWorld();
            _currentLocation = _currentWorld.LocationAt(0, -1);
        }

        public Player CurrentPlayer
        {
            get
            {
                return _currentPlayer;
            }
        }

        public Location CurrentLocation
        {
            get
            {
                return _currentLocation;
            }
        }
    }
}
