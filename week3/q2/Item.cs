using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class Item
    {
        private int price;
        private string name;
        public delegate void PriceChangedHandler(int v);
        public event PriceChangedHandler PriceChanged;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                if (PriceChanged != null)
                {
                    PriceChanged(value);
                }
                
            }
        }
    }
}
