using Engine.Factories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public enum PlayerClass
    {
        Warrior,
        Mage,
        Rogue
    }

    public class Player : BaseNotification
    {
        private string _name;
        private readonly PlayerClass _characterClass;
        private uint _hitPoints;
        private uint _damage;
        private uint _experiencePoints;
        private uint _level;
        private uint _gold;
        private ObservableCollection<GameItem> _inventory;

        public Player(string name, PlayerClass characterClass)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("The NAME can't be null, empty or only whitespace.");
            }

            if (characterClass == null)
            {
                throw new ArgumentException("The CHARCTER CLASS can't be null.");
            }
            _name = name;
            _characterClass = characterClass;
            _experiencePoints = 0;
            _level = 1;
            _gold = 10;
            _inventory = new ObservableCollection<GameItem>();
            _inventory.Add(ItemFactory.CreateGameItem(1001));

            if (_characterClass == PlayerClass.Warrior)
            {
                _damage = 10;
                _hitPoints = 120;
            }

            if (_characterClass == PlayerClass.Mage)
            {
                _damage = 20;
                _hitPoints = 70;
            }

            if (_characterClass == PlayerClass.Rogue)
            {
                _damage = 13;
                _hitPoints = 90;
            }
        }

        public ObservableCollection<GameItem> Inventory
        {
            get
            {
                return _inventory;
            }
            set
            {
                _inventory = value;
            }
        }


        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 15)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Üres vagy túl hosszú a karakter név amit megadnál");
                }
            }
        }

        public PlayerClass CharacterClass
        {
            get 
            { 
                return _characterClass; 
            }
        }

        public uint HitPoints
        {
            get
            {
                return _hitPoints;
            }
            set
            {
                _hitPoints = value;
                OnPropertyChange(nameof(HitPoints));
            }
        }

        public uint Damage
        {
            get
            {
                return _damage;
            }
            set
            {
                _damage = value;
                OnPropertyChange(nameof(Damage));
            }
        }

        public uint ExperiencePoints
        {
            get
            {
                return _experiencePoints;
            }
            set
            {
                _experiencePoints = value;
                OnPropertyChange(nameof(ExperiencePoints));
            }
        }

        public uint Level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
                OnPropertyChange(nameof(Level));
            }
        }

        public uint Gold
        {
            get
            {
                return _gold;
            }
            set
            {
                _gold = value;
                OnPropertyChange(nameof(Gold));
            }
        }
    }
}
