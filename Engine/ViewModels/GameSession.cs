using Engine.Factories;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession : BaseNotification
    {
        private Player _currentPlayer;
        private Location _currentLocation;
        private World _currentWorld;

        public GameSession()
        {
            _currentPlayer = new Player("Scott", PlayerClass.Warrior);
            _currentWorld = WorldFactory.CreateWorld();
            _currentLocation = _currentWorld.LocationAt(0, -1);
        }

        public void MovePlayer(int xCoordinate, int yCoordinate)
        {
            Location newLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + xCoordinate, CurrentLocation.YCoordinate + yCoordinate);
            if (newLocation != null)
            {
                CurrentLocation = newLocation;
            }
        }

        public bool HasLocationNorth
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
            }
        }

        public bool HasLocationWest
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null;
            }
        }

        public bool HasLocationEast
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;
            }
        }

        public bool HasLocationSouth
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;
            }
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
            set
            {
                _currentLocation = value;
                OnPropertyChange(nameof(CurrentLocation));
                OnPropertyChange(nameof(HasLocationNorth));
                OnPropertyChange(nameof(HasLocationEast));
                OnPropertyChange(nameof(HasLocationWest));
                OnPropertyChange(nameof(HasLocationSouth));
            }
        }

        public World CurrentWorld
        {
            get
            {
                return _currentWorld;
            }
        }
    }
}
