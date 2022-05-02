using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBreaker
{
    public class Item
    {
        private int _amount;
        private int _itemID;
        private string _imageName;
        
        public int amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public int itemID
        {
            get { return _itemID; }
            set { _itemID = value; }
        }
        virtual public string imageName
        {
            get { return _imageName; }
            set { _imageName = value; }
        }
        public Item() { }
        public Item(int itemID, string imageName)
        {
            _itemID = itemID;
            _imageName = imageName;
            amount = 0;
        }
    }
}
