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

    class overloading
    {
       public int sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public float sum(float a, float b)
        {
            float sum = a + b;
            return sum;
        }

    }
    
    class StudentTest
    {
        static void Main(string[] args)
        {
            overloading ol = new overloading();
            Console.WriteLine(ol.sum(12, 11));
            Console.WriteLine(ol.sum(2.3f, 2.5f));
            Console.ReadKey();
            
        }

    }
}
