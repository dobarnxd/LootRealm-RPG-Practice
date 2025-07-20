using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon : GameItem
    {
        private int _minimumDamage;
        private int _maximumDamage;

        public Weapon(int itemTypeID, string name, int price, int minimumDamage, int maximumDamage) : base(itemTypeID, name, price)
        {
            if (minimumDamage <= 0)
            {
                throw new ArgumentException("The MINIMUM DAMAGE has to be greater than 0.");
            }
            if(maximumDamage < minimumDamage)
            {
                throw new ArgumentException("The MAXIMUM DAMAGE has to be greater than MINIMUM DAMAGE.");
            }

            _minimumDamage = minimumDamage;
            _maximumDamage = maximumDamage;
        }

        public new Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, MinimumDamage, MaximumDamage);
        }

        public override string ToString()
        {
            return $"{Name} (Damage: {MinimumDamage} - {MaximumDamage}, Price: {Price})";
        }

        public int MinimumDamage
        {
            get
            {
                return _minimumDamage;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The MINIMUM DAMAGE has to be greater than 0.");
                }
                _minimumDamage = value;
            }
        }

        public int MaximumDamage
        {
            get
            {
                return _maximumDamage;
            }
            set
            {
                if (value < _minimumDamage)
                {
                    throw new ArgumentException("The MAXIMUM DAMAGE has to be greater than MINIMUM DAMAGE.");
                }
                _maximumDamage = value;
            }
        }
    }
}
