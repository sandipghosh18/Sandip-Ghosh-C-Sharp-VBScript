
using System.IO;
using System;

namespace ConsoleApp2
{

    public struct Employee
    {
        public int EmployeeID;
        public String EmployeeName;
    }


    class Program
    {


        public static void Main()
        {
            Employee emp;
            emp.EmployeeID = 12600;
            emp.EmployeeName = "Sandip";
            printEmployeeDeatils(emp);
            Console.ReadKey();

        }

        public static void printEmployeeDeatils(Employee emp)
        {
            Console.WriteLine("Employee Id={0}, Employee Name={1}", emp.EmployeeID, emp.EmployeeName);
        }
        
    }
}
