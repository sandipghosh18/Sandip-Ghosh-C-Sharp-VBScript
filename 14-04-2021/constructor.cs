using System;
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

    class student
    {
        private String name;
        private int studentID;
        private Char gender;

        public String _name
        {
            set { name = value; }
            get { return name; }
        }

        public int _studentID
        {
            set { studentID = value; }
            get { return studentID; }
        }

        public Char _gender
        {
            set { gender = value; }
            get { return gender; }

        }


        //parametrized constructor   
        public student(String name,int Id,Char gender)
        {
            this.name = name;
            this.studentID = Id;
            this.gender = gender;
        }

        public void display()
        {
            Console.WriteLine("Name: {0}, Student Id: {1}, Gender: {2}", name, studentID, gender);
        }

    }
    
    class StudentTest
    {
        static void Main(string[] args)
        {
            student std = new student("Sandip",121,'M');
            std.display();
            Console.WriteLine(std._studentID);
            Console.ReadKey();
            
        }

    }
}
