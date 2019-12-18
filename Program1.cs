using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPrac1
{
    class Program
    {
        static void Main(string[] args)
        {
            AllArea all = new AllArea();
            Console.Write("Enter Height of square:");
            int x=Convert.ToInt32(Console.ReadLine());
            all.area(x);


            Console.Write("Enter Height of Reactangle:");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Length of Reactangle:");
            int l = Convert.ToInt32(Console.ReadLine());
            all.area(h, l);


            Console.Write("Enter Redius of Circle:");
            int r = Convert.ToInt32(Console.ReadLine());
            all.area(r);


            Console.ReadKey();

        }
    }

    public class AllArea
    {
        public void area(int h)
        {
            int a = h * h;
            Console.WriteLine("Area of square:"+a);
           // Console.ReadLine();
        }
        public void area(int h, int l)
        {
            int a = l * h;
            Console.WriteLine("area of ractangle:"+ a);
            //Console.ReadLine();
        }
        public void area( int r, double pi = 3.14)
        {
            double a = pi * r * r;
            Console.WriteLine("Area of circle:"+ a);
            //Console.ReadLine();
        }
    }
}
