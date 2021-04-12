using System.IO;
using System;


class Program
{


    public static void Main()
    {
        int[,] arr = new int[3, 3];

        Console.WriteLine("Enter element 1 by 1");

        for(int i=0;i<arr.GetLength(0);i++)
        {
            for(int j=0;j<arr.GetLength(1);j++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                arr[i, j] = num;
            }
        }
        Console.WriteLine("The matrix");

        for(int i=0;i<arr.GetLength(0);i++)
        {
            for(int j=0;j<arr.GetLength(1);j++)
            {
                Console.Write(arr[i, j] +"\t");
            }
            Console.WriteLine("\n");
        }


        //Transpose of the matrix
        Console.Write("The transpose\n");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[j, i] + "\t");
            }
            Console.WriteLine("\n");
        }






        Console.ReadKey();
    }
}
