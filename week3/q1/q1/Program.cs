using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
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
            int[] rev = new int[n];
            Console.WriteLine("\nReverse");
            for (int i = 0; i < n; i++)
            { rev[i] = arr[n - 1 - i];
                Console.WriteLine(rev[i]);
            }


            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n-1-i;j++)
                {
                    if(arr[j]>arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nSorted Array");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.Read();
        }
    }
}
