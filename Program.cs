using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thirdprac1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] ex_arr = new int[][] { new int[] { 32, 22, 0 }, new int[] { 33, 4, 12 }, new int[] { 9, 0, 0 } };
            var qry = from x in ex_arr select Sort(x);

            int[][] sorted = qry.ToArray<int[]>();

            Console.WriteLine(sorted[0][0]+","+ sorted[0][1]+","+ sorted[0][2]);
            Console.WriteLine(sorted[1][0] + "," + sorted[1][1] + "," + sorted[1][2]);



            int[] Sort(int[] arr)
            {
                Array.Sort(arr);
                return arr;
            }

            Console.ReadLine();

        }

        
    }
}
