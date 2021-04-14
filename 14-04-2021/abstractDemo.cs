using System;
using System.IO;

namespace Day2
{
    public abstract class abstractClass
    {
        //ABSTRACT METHOD
        public abstract int multiply(int a, int b);

        //NON-ABSTRACT METHOD
        public int sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
    }

    public class derived :abstractClass
    {
        public override int multiply(int a, int b)
        {
            int mul = a * b;
            return mul;
        }
    }
    

   

    public class Exec
    {
        static void Main(string[] args)
        {

            derived dd = new derived();
            Console.WriteLine(dd.multiply(12, 5));
            Console.WriteLine(dd.sum(12, 12));
            Console.ReadKey();

        }
    }
}
