using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secondprac1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            int min, max, n, i;

            Console.Write("Input number of element to input in array:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("input {0} elements in array\n", n);
            for(i=0;i<n;i++)
            {
                Console.Write("Element -{0}:",i);
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }

            min = arr[0];
            max = arr[0];

            for(i=0;i<n;i++)
            {
                if(arr[i]>max)
                {
                    max = arr[i];
                }
                if(arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.Write("Maximum elements value is{0}\n",max);
            Console.Write("Minimum elements value is{0}\n", min);
            Console.ReadLine();

        }
    }
}
