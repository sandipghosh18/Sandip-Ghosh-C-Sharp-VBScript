using System.IO;
using System;

namespace day3
{ 
  public interface rbi
    {
        void rate();
    }

    class sbi : rbi
    {
        public void rate()
        {
            Console.WriteLine("rate is 12.55");
        }
    }
    class ubi: rbi
    {
        public void rate()
        {
            Console.WriteLine("rate is 18.55");
        }
    }
   
    class Program
{
    static void Main(string[] args)
    {
            sbi sb = new sbi();
            sb.rate();
            ubi ub = new ubi();
            ub.rate();

            Console.ReadKey();
    }
}
}
