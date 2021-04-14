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
    
    class emp
    {
        private int empno;
        private String ename;
        private float sal;

        public void getdata(int empno,String ename,float sal)
        {
            this.empno = empno;
            this.ename = ename;
            this.sal = sal;
        }

        public void display()
        {
            Console.WriteLine("Empno: {0}, Ename: {1}, sal: {2}", empno, ename, sal);
        }
    }

    class dept: emp
    {
        private int depno;
        private String depname;

        public void getdept(int depno,String depname)
        {
            this.depno = depno;
            this.depname = depname;
        }

        public void displayDep()
        {
            Console.WriteLine("depno: {0}, depname: {1}", depno,depname);
        }
    }
    
    
    class StudentTest
    {

       
        static void Main(string[] args)
        {
            dept obj = new dept();
            obj.getdata(102, "Sandip", 12346f);
            obj.getdept(121, "VnV Automation");

            obj.display();
            obj.displayDep();

            Console.ReadKey();
            
        }
    }
}
