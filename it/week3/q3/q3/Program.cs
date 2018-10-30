using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            int.TryParse(Console.ReadLine(), out n);
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
                int.TryParse(Console.ReadLine(), out arr[i]);

            int max=arr[0],pmax=arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    pmax = max;
                    max = arr[i];
                }
            }
            Console.WriteLine( "\nsecond largest is: "+pmax);
            Console.Read();
        }
    }
}
