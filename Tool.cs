using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBreaker
{
    public class Tool : Item
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
        override public string imageName
        {
            get
            {
                if (toolLevel == 0)
                    return "inventorySlot.png";
                else if (toolLevel == 1)
                    return "wooden" + toolType + ".png";
                else if (toolLevel == 2)
                    return "stone" + toolType + ".png";
                else if (toolLevel == 3)
                    return "iron" + toolType + ".png";
                else if (toolLevel == 4)
                    return "diamond" + toolType + ".png";
                else
                    return "inventorySlot.png";
            }
        }
        public Tool(int durability, string toolType, int fitemID)
        {
            _durability = durability;
            _toolType = toolType;
            _toolLevel = 0;
            itemID = fitemID;
        }


    }

}
