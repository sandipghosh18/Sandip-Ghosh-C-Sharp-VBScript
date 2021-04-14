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

            int[][] arr = new int[3][] {
            new int [] {12,22,33,44},
            new int [] {12,44,5},
            new int[] {12,55}
        };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write(arr[i][j] + " ");
                }
                System.Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
