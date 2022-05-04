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

        #region Properties
        public double breakTime
        {
            get 
            { 
                if(Form_main.tools[preferredTool].efficiencyLevel == 5)
                {
                    return ((_breakTime * 1000) / 6);
                }
                else if (Form_main.tools[preferredTool].efficiencyLevel == 4)
                {
                    return ((_breakTime * 1000) / 5);
                }
                else if (Form_main.tools[preferredTool].efficiencyLevel == 3)
                {
                    return ((_breakTime * 1000) / 4);
                }
                else if (Form_main.tools[preferredTool].efficiencyLevel == 2)
                {
                    return ((_breakTime * 1000) / 3);
                }
                else if (Form_main.tools[preferredTool].efficiencyLevel == 1)
                {
                    return ((_breakTime * 1000) / 2);
                }
                else
                    return _breakTime * 1000; 
            }
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
                if (Form_main.tools[preferredTool].fortuneLevel == 3)
                {
                    if (_dropAmount == -1)
                    {
                        Random rnd = new Random();
                        return rnd.Next(4, 9) + 3;
                    }
                    else if (_dropAmount == 0)
                        return _dropAmount;
                    else
                        return _dropAmount + 3;
                }
                else if (Form_main.tools[preferredTool].fortuneLevel == 2)
                {
                    if (_dropAmount == -1)
                    {
                        Random rnd = new Random();
                        return rnd.Next(4, 9) + 2;
                    }
                    else if (_dropAmount == 0)
                        return _dropAmount;
                    else
                        return _dropAmount + 2;
                }
                else if (Form_main.tools[preferredTool].fortuneLevel == 1)
                {
                    if (_dropAmount == -1)
                    {
                        Random rnd = new Random();
                        return rnd.Next(4, 9) + 1;
                    }
                    else if (_dropAmount == 0)
                        return _dropAmount;
                    else
                        return _dropAmount + 1;
                }
                else
                {
                    if (_dropAmount == -1)
                    {
                        Random rnd = new Random();
                        return rnd.Next(4, 9);
                    }
                    else if (_dropAmount == 0)
                        return _dropAmount;
                    else
                        return _dropAmount;
                }
            }
            set { _dropAmount = value; }
        }
        public int breakLevel
        {
            get { return _breakLevel; }
            set { _breakLevel = value; }
        }
        #endregion

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
