using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBreaker
{
    public class Block : Item
    {
        private double _breakTime;
        private string _preferredTool;
        private int _dropAmount;
        private int _breakLevel;

        public double breakTime
        {
            get { return _breakTime; }
            set { _breakTime = value; }
        }
        public string preferredTool
        {
            get { return _preferredTool; }
            set { _preferredTool = value; }
        }
        public int dropAmount
        {
            get 
            {
                if (_dropAmount == -1)
                {
                    Random rnd = new Random();
                    return rnd.Next(4, 9);
                }
                else
                    return _dropAmount;
            }
            set { _dropAmount = value; }
        }
        public int breakLevel
        {
            get { return _breakLevel; }
            set { _breakLevel = value; }
        }
        public Block(int fitemID, double breakTime, string preferredTool, int dropAmount, int breakLevel, string fimageName)
        {
            itemID = fitemID;
            _breakTime = breakTime;
            _preferredTool = preferredTool;
            amount = 0;
            _dropAmount = dropAmount;
            _breakLevel = breakLevel;
            imageName = fimageName;
        }
        
    }
}
