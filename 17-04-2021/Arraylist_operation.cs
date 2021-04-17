using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP16
{
    
    class arraylistdemo
    {
        ArrayList al = new ArrayList();
        ArrayList al2 = new ArrayList() { 1, 4, 5, 6, 7, 9 };
       // var al3 = new ArrayList() { 3, 5, 6, 6, 7, 7, 8 };
        //int[] arr = new int[al3.Count];

        public void add()
        {
            Console.WriteLine("Enter the number of element");
            int x = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<x;i++)
            {
                Console.WriteLine("Enter the {0} element",i);
                int y = Convert.ToInt32(Console.ReadLine());
                al.Add(y);

            }
        }

        public void display()
        {
            Console.WriteLine("--------------------------------------------");
            foreach (var z in al)
            {
                Console.WriteLine(z);
            }
        }

        public void insert()
        {
            al.Insert(3, 7899);
        }

        public void insertRange()
        {
            al.InsertRange(2, al2);
        }

        public void count()
        {
            Console.WriteLine("size of arraylist 1: {0}  & Arraylist 2: {1}",al.Count,al2.Count);
        }

        public void sort()
        {
            al.Sort();
        }
        public void reverse()
        {
            al.Reverse();
        }

        public void indexof(int x)
        {
            Console.WriteLine("The index of 44={0}", al.IndexOf(44));
            
        }

        public void remove()
        {
            al.Remove(7899);
        }

        public void removeRange()
        {
            al.RemoveRange(0, 3);
        }

        public void gettype()
        {
            Console.WriteLine("The type--->{0}",al.GetType());
        }

        public void copy()
        {
            
        }
        

        public void clear()
        {
            al.Clear();
        }
    }

    
   
    class Program
    {


        static void Main(string[] args)
        {

            arraylistdemo ad = new arraylistdemo();
            ad.add();
            Console.WriteLine("After adding elements");
            ad.display();
            ad.insert();
            Console.WriteLine("After inserting 7899");
            ad.display();
            ad.insertRange();
            Console.WriteLine("After Inserting range");
            ad.display();
            Console.WriteLine("----------------------------");
            ad.count();
            Console.WriteLine("Index of 44---->");
            ad.indexof(44);
            ad.sort();
            Console.WriteLine("After Sorting");
            ad.display();
            ad.reverse();
            Console.WriteLine("After reverse range");
            ad.display();
            ad.remove();
            Console.WriteLine("After removing 7899");
            ad.display();
            Console.WriteLine("After removing range 0 to 2");
            ad.removeRange();
            ad.display();
            ad.gettype();
            ad.copy();
            ad.clear();
            ad.display();
            
            Console.ReadKey();
        }
     }
}

    
