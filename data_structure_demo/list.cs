using System;
using System.Collections.Generic;
using System.IO;

namespace Day2
{
 class data
    {
        private int id;
        private  String name;
        public data(int id,String name)
        {
            this.id = id;
            this.name = name;
        }

        public int _id
        {
            get { return id; }
        }

        public String _name
        {
            get { return name; }
        }
    }

    class student
    {
        
        List<data> li = new List<data>();
        public void add(data dt)
        {
            li.Add(dt);
        }

        public void display()
        {
            foreach(data di in li)
            {
                Console.WriteLine("Name: {0}, Id: {1}",di._id,di._name);
            }
        }
    }




    public class Exec
    {
        static void Main(string[] args)
        {
            data dd1 = new data(12, "sandip");
            data dd2= new data(13, "aditi");

            student st = new student();
            st.add(dd1);
            st.add(dd2);

            st.display();

            Console.ReadKey();
        }
    }
}
