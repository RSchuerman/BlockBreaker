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
        private int _fortuneLevel;
        private int _unbreakingLevel;
        private int _efficiencyLevel;

        #region Properties
        public int durability
        {
            get { return _durability; }
            set { _durability = value; }
        }
        public int fortuneLevel
        {
            get { return _fortuneLevel; }
            set { _fortuneLevel = value; }
        }
        public int unbreakingLevel
        {
            get { return _unbreakingLevel; }
            set { _unbreakingLevel = value; }
        }
        public int efficiencyLevel
        {
            get { return _efficiencyLevel; }
            set { _efficiencyLevel = value; }
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
        #endregion

        public Tool(int durability, string toolType, int fitemID)
        {
            _durability = durability;
            _toolType = toolType;
            _toolLevel = 0;
            itemID = fitemID;
            _fortuneLevel = 0;
            _unbreakingLevel = 0;
            _efficiencyLevel = 0;
        }


    }

}
