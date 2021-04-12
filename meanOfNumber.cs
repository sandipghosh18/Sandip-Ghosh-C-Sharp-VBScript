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


            int firstNumber, secondNumber, thirdNumber;
            float mean;

            Console.WriteLine("Enter the First Number");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            thirdNumber = Convert.ToInt32(Console.ReadLine());

            mean = (firstNumber + secondNumber + thirdNumber) / 3;

            Console.WriteLine("The mean of 3 number is {0:F2}", mean);

            

            Console.ReadKey();


        }
    }
}
