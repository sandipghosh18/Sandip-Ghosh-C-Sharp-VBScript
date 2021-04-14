
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Program demonstrates  Static variable, Static Method,
 * Static Constructor and Default Constructor
 */
namespace OOP03
{
    class stack
    {

        Stack sk = new Stack();
        int top = 0;

        public void push(int a)
        {
            sk.Push(a);
            top++;
            Console.WriteLine("The element is pushed");
        }

        public void pop()
        {
            if(top==0)
            {
                Console.WriteLine("The stack is empty");
                
            }
            else
            { 
            sk.Pop();
            top--;
            Console.WriteLine("The element is poped");
            }
        }
        public void display()
        {
            Console.WriteLine("***************The stack******************");
            foreach (int i in sk)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*******************************************");
        }
        
    }
    
    
    class StudentTest
    {
        static void Main(string[] args)
        {

            stack st = new stack();
            while(true)
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("Enter 1: for push\n Enter 2: for Pop");
                int choice= Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        st.push(12);
                        break;
                    case 2:
                        st.pop();
                        break;
                    case 3:
                        st.display();
                        break;
                    default:
                        Console.WriteLine("Enter correct option");
                        break;

                }
            }
            Console.ReadKey();
            
        }

    }
}
