using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    class Item
    {
        public static double cost;
        public string name { get;set; }

 
        public double Cost
        {
            get
            {
                return cost;
            }
            set
            {

                if (value < 0)
                {
                    cost = 0;
                }
                else
                    cost = value;
                
            }
        }
    }
}
