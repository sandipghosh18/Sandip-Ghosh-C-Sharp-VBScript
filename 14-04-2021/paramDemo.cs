using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Program demonstrates  Static variable, Static Method,
 * Static Constructor and Default Constructor
 */
namespace OOP03
{
    class paramdemo
    {
        
        public int sum(params int[] param1)
        {
            int val = 0;
            foreach(int p in param1)
            {
                val += p;
            }
            return val;
        }
        
    }
    
    
    class StudentTest
    {
        static void Main(string[] args)
        {
            paramdemo pd = new paramdemo();
            Console.WriteLine(pd.sum(1, 2, 3, 4));
            Console.WriteLine(pd.sum(1, 2, 3, 4,4,5,6,7,8));
            Console.ReadKey();
            
            
        }

    }
}
