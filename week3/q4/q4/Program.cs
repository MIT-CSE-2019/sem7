using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4
{
    class Program
    {
        static void Main(string[] args)
        {

            Item i = new Item();
            i.Cost = 10;
            Console.WriteLine("GST is : "+CalcGst(i.Cost));
            Console.Read();
        }

        private static double CalcGst(double cost)
        {
            return 0.08 * cost;
        }
    }
}
