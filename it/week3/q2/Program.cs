using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Item i = new Item();
            i.PriceChanged += ShowPriceChangedMessage;
            i.Price = 20;
            i.Price = 200;
            Console.Read();

        }

        private static void ShowPriceChangedMessage(int v)
        {
            Console.WriteLine("New Price : "+v);
        }
    }
}
