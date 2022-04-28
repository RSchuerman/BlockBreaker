using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBreaker
{
    class Tool
    {
        private int _durability;
        private string _toolType;
        private int _toolLevel;
        public int durability
        {
            get { return _durability; }
            set { _durability = value; }
        }
        public string toolType
        {
            get { return _toolType; }
            set { _toolType = value; }
        }
        public int toolLevel
        {
            get { return _toolLevel; }
            set { _toolLevel = value; }
        }
        public Tool(int durability, string toolType, int toolLevel)
        {
            _durability = durability;
            _toolType = toolType;
            _toolLevel = 0;
        }


    }

}
