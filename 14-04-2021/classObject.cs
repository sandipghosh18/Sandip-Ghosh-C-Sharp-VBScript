using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class circle
    {
        int radius;
        public circle(int r)
        {
            radius = r;
        }
    }


    public class square
    {
        int length;
        public square(int l)
        {
            length = l;
        }
    }
    public class istest
    {
        circle c;
        square s;
        public  void test(object o)
        {
            if(o is circle)
            {
                Console.WriteLine("o is circle");
            }
            else if(o is square)
            {
                Console.WriteLine("o is square");
            }
            else
            {
                Console.WriteLine("o is nither circle nor square");
            }
        }
    }


    class Program
    {
        static void Main()
        {

            circle c = new circle(10);
            square s = new square(12);
            istest it = new istest();
            it.test(s);

            Console.ReadKey();


        }
    }
}
