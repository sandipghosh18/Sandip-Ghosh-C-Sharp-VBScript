using System.IO;
using System;

namespace day3
{ 
 

 class Program
{
    static void Main(string[] args)
    {
            int result, divisor, dividend;

            err:
            try
            {
                Console.WriteLine("Enter the dividend");
                divisor = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the divisor");
                dividend = Convert.ToInt32(Console.ReadLine());
                result = dividend / divisor;
                Console.WriteLine("The result is: {0}", result);

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                goto err;
            }
            
            Console.ReadKey();
    }
}
}
