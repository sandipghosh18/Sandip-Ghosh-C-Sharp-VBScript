using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP16
{
    class calculator
    {
        public double add(double a, double b)
        {
            double sum = a + b;
            return sum;
        }

        public double sub(double a, double b)
        {
            double sub = a-b;
            return sub;
        }

        public double Multiply(double a, double b)
        {
            double mul = a * b;
            return mul;
        }

        public double div(double a, double b)
        {
            double div;
            if(b==0)
            {
                Console.WriteLine("The number b can't be zero");
            }
            else
            {
               div = a / b;
                return div;
                
            }
            return 0;
            
        }

        public double first()
        {
            Console.Write("\nEnter the first Number :\n");
            double a = Convert.ToInt32(Console.ReadLine());

            return a;
        }

        public double second()
        {
            Console.Write("\nEnter the second Number :\n");
            double b = Convert.ToInt32(Console.ReadLine());

            return b;
        }

        public double mod(double a, double b)
        {
            double mod = a / b;
            return mod;
        }

        public double sqt(double a)
        {
            double sqt = Math.Sqrt(a);
            return sqt;
        }

        public double pow(double a,double b)
        {
            double pow = Math.Pow(a, b);
            return pow;

        }





    }
   
    class Program
    {


        static void Main(string[] args)
        {
            while(true)
            {
                
                Console.Write("\nHere are the options :\n");
                Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Mod.\n6-Sqrt.\n7-Pow.\n8-Exit.\n");
                Console.Write("\nEnter the the options :\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                calculator cl = new calculator();

                switch(choice)
                {
                    case 1:
                        double a1 =cl.first();
                        double b1 =cl.second();
                        double result =cl.add(a1, b1);
                        Console.WriteLine("The result is: {0}", result);
                        break;

                    case 2:
                        double a2 = cl.first();
                        double b2 = cl.second();
                        double sub = cl.sub(a2, b2);
                        Console.WriteLine("The result is: {0}", sub);
                        break;

                    case 3:
                        double a3 = cl.first();
                        double b3 = cl.second();
                        double mal = cl.Multiply(a3, b3);
                        Console.WriteLine("The result is: {0}", mal);
                        break;

                    case 4:
                        double a4 = cl.first();
                        double b4 = cl.second();
                        double div = cl.div(a4, b4);
                        Console.WriteLine("The result is: {0}", div);
                        break;
                    case 5:
                        double a5 = cl.first();
                        double b5 = cl.second();
                        double mod= cl.mod(a5, b5);
                        Console.WriteLine("The result is: {0}", mod);
                        break;

                    case 6:
                        double a6 = cl.first();
                        double sqrt = cl.sqt(a6);
                        Console.WriteLine("The result is: {0}", sqrt);
                        break;

                    case 7:
                        double a7 = cl.first();
                        double b7 = cl.second();
                        double pow = cl.pow(a7,b7);
                        Console.WriteLine("The result is: {0}", pow);
                        break;
                    case 8:
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;


                }
            }

            Console.ReadKey();
        }
    }
}
