using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Location
    {
        private int _xCoordinate;
        private int _yCoordinate;
        private string _name;
        private string _description;
        private string _imageName;

        public Location()
        {
            _name = "Home";
            _xCoordinate = 0;
            _yCoordinate = -1;
            _description = "This is your house";
            _imageName = "/Engine;component/Images/Locations/Home.png";
        }

        public int XCoordinate
        {
            get
            {
                return _xCoordinate;
            }
            set
            {
                _xCoordinate = value;
            }
        }

        public int YCoordinate
        {
            get
            {
                return _yCoordinate;
            }
            set
            {
                _yCoordinate = value;
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
                _name = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public string ImageName
        {
            get
            {
                return _imageName;
            }
            set
            {
                _imageName = value;
            }
        }
    }
}
