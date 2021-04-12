using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            String format;

            //CURRENCY

            format = "Currency";
            Console.WriteLine("{0} Format: ",format);
            Console.WriteLine("{0:C}", 1.2);
            Console.WriteLine("{0:C}", -1.2);

            //DECIMAL
            format = "Decimal";
            Console.WriteLine("\n{0} Format: ", format);
            Console.WriteLine("{0:D5}",123);

            //FIXED POINT
            format = "Fixed-point";
            Console.WriteLine("\n{0} Format: ", format);
            Console.WriteLine("{0:F2}", 12);
            Console.WriteLine("{0:F0}", 12);
            Console.WriteLine("{0:F0}", 12.3);
            Console.WriteLine("{0:F2}", 12.3);


            //GENERAL
            format = "General";
            Console.WriteLine("\n{0} Format: ", format);
            Console.WriteLine("{0:G}", 1.2);
            Console.WriteLine("{0}", 1.23);

            //NUMERIC

            format = "Numeric";
            Console.WriteLine("\n{0} Format: ", format);
            Console.WriteLine("{0:N}", 123000);

            //HEXADECIMAL

            format = "Hexadecimal";
            Console.WriteLine("\n{0} Format: ", format);
            Console.WriteLine("{0:X}", 123);
            Console.WriteLine("{0:X}", 12345);




            Console.ReadKey();


        }

    }
}
