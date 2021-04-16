using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP16
{
    class ticketReservation
    {
        private int employeeId;
        private String employeeName;
        private String travelLocation;

        
       public ticketReservation(int employeeId,String employeeName,String travelLocation)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.travelLocation = travelLocation;
        }

        public int _employeeId
        {
            get { return employeeId; }
        }

        public String _employeeName
        {
            get { return employeeName; }
        }

        public String _travelLocation
        {
            get { return travelLocation; }
        }

       
    }

    class user 
    {
        List<ticketReservation> userData = new List<ticketReservation>();

        public void buyTicket()
        {
            int employeeId;
            String employeeName;
            String travelLocation;

            userid:
            Console.WriteLine("Enter the employee Id");
            try { 
            employeeId = Convert.ToInt16(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a valid Employee Id");
                goto userid;
            }

            Console.WriteLine("Enter the employee Name");


        }

        public void showTicket()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            user us = new user();
            us.buyTicket();
            Console.ReadKey();
        }
    }
}
