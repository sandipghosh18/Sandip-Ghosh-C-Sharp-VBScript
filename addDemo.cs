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


            int firstNumber, secondNumber,result;

            Console.WriteLine("Enter the First Number");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Second number");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            result = firstNumber + secondNumber;

            Console.WriteLine("The sum of " + firstNumber + " and " + secondNumber + "is " + result);

            Console.ReadKey();


        }
    }
}
