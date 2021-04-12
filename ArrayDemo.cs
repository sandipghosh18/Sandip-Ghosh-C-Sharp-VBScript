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


            int []arr = new int[5];
            int sum = 0;

            Console.WriteLine("Enter the values");

            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Enter the {0} values",i+1);
                int num = Convert.ToInt32(Console.ReadLine());
                arr[i] = num;
            }

            Console.WriteLine("The array elemnents are");

            foreach(int j in arr)
            {
                Console.WriteLine("{0}",j);
            }

            for(int i=0;i<arr.Length;i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("The result of sum is {0}",sum);




            Console.ReadKey();


        }
    }
}
