using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        private Player _currentPlayer;
        private Location _currentLocation;

        public GameSession()
        {
            _currentPlayer = new Player("Scott", PlayerClass.Warrior);
            _currentLocation = new Location();
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
