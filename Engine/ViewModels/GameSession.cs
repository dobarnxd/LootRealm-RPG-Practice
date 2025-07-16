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

        public GameSession()
        {
            _currentPlayer = new Player("Scott", PlayerClass.Warrior);
        }

        public Player CurrentPlayer
        {
            get
            {
                return _currentPlayer;
            }
        }
    }
}
