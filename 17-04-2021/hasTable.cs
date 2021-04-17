using System;
using System.Collections;

namespace DemoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("001", ".Net");
            ht.Add("002", "C#");
            ht.Add("003", "ASP.Net");

            ICollection keys = ht.Keys;

            foreach (String k in keys)
            {
                Console.WriteLine(ht[k]);
            }
            Console.ReadKey();
        }
    }
}
