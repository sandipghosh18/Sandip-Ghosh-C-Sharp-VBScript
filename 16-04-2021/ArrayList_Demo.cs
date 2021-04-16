using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP16
{
    class arraylist
    {
       

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(12);
            al.Add(14);
            al.Add(45);
            //al.Add("sandip");
            int[] arr = { 12, 44, 55, 67, 88 };
            foreach(int x in arr)
            {
                al.Add(x);
            }

            foreach(var a in al)
            {
                Console.WriteLine(a);
            }
            al.Sort();

            
            Console.WriteLine("The total element: {0}", al.Count);

            foreach (var c in al)
            {
                Console.WriteLine(c);
            }
            al.RemoveAt(3);
            Console.WriteLine("---------------------");
            foreach (var c in al)
            {
                Console.WriteLine(c);
            }
            al.RemoveRange(2, 5);

            Console.WriteLine("---------------------");
            foreach (var c in al)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
