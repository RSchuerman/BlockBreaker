using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBreaker
{
    public class Block
    {
        private int _blockID;
        private double _breakTime;
        private string _preferredTool;
        private int _amount;
        private int _dropAmount;
        private int _breakLevel;
        
        public double breakTime
        {
            get { return _breakTime; }
            set { _breakTime = value; }
        }
        public int amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public string preferredTool
        {
            get { return _preferredTool; }
            set { _preferredTool = value; }
        }
        public int dropAmount
        {
            get { return _dropAmount; }
            set { _dropAmount = value; }
        }
        public int breakLevel
        {
            get { return _breakLevel; }
            set { _breakLevel = value; }
        }
        public Block(int blockID, double breakTime, string preferredTool, int dropAmount, int breakLevel)
        {
            _blockID = blockID;
            _breakTime = breakTime;
            _preferredTool = preferredTool;
            _amount = 0;
            _dropAmount = dropAmount;
            _breakLevel = breakLevel;
        }
        
    }
}
