using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Engine.Models
{
    public class GameItem
    {
        private int _itemTypeID;
        private string _name;
        private int _price;

        public GameItem(int itemTypeID, string name, int price)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("The NAME can't be null, empty or only whitespace.");
            }
            if (itemTypeID < 0)
            {
                throw new ArgumentException("The ITEMTYPEID has to be greater or equal than 0.");
            }
            if (price < 0)
            {
                throw new ArgumentException("The PRICE has to be greater or equal than 0.");
            }

            _itemTypeID = itemTypeID;
            _name = name;
            _price = price;
        }

        public GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, Price);
        }

        public override string ToString()
        {
            return $"{Name} (ItemTypeID: {ItemTypeID}, Price: {Price})";
        }

        public int ItemTypeID
        {
            get
            {
                return _itemTypeID;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The ITEMTYPEID has to be greater or equal than 0.");
                }
                _itemTypeID = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The NAME can't be null, empty or only whitepsace.");
                }
                _name = value;
            }
        }

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The PRICE has to be greater or equal than 0.");
                }
                _price = value;
            }
        }
    }
}
