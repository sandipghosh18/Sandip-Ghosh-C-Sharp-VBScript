using System.IO;
using System;

namespace day3
{ 
  public interface rbi
    {
        void rate();
    }

  public interface rbb
    {
        void rate();
    }

    class sbi : rbi,rbb
    {
         void rbi.rate()
        {
            Console.WriteLine("SBI rate for RBI---> 12.55");
        }
         void rbb.rate()
        {
            Console.WriteLine("SBI rate is for RBB----> 12.55");
        }

    }
    class ubi: rbi,rbb
    {
         void rbi.rate()
        {
            Console.WriteLine("UBI rate  FOR RBI------> 18.55");
        }
        void rbb.rate()
        {
            Console.WriteLine("UBI rate FOR RBB-----> 11.55");
        }
    }
   
    class Program
{
    static void Main(string[] args)
    {
            rbi ri = new sbi();
            rbb rbb = new sbi();


            ri.rate();
            rbb.rate();


            rbi ri1 = new ubi();
            rbb rb1 = new ubi();

            ri1.rate();
            rb1.rate();


            Console.ReadKey();
    }
}
}
