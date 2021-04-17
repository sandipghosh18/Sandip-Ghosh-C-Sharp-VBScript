using System;
using System.Collections;

namespace DemoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(123);
            q.Enqueue(877);
            q.Enqueue("Sandip");
            q.Enqueue(true);

            foreach(var x in q)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("peak--->{0}",q.Peek());

            q.Dequeue();

            foreach(var x in q)
            {
                Console.WriteLine(x);
            }








            Console.ReadKey();


           
            
        }
    }
}
