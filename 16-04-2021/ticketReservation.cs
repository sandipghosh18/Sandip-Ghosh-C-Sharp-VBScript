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


        public ticketReservation(int employeeId, String employeeName, String travelLocation)
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
            try
            {
                employeeId = Convert.ToInt16(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid Employee Id");
                goto userid;
            }

            Console.WriteLine("Enter the employee Name");
            employeeName = (Console.ReadLine());

            dd:
            Console.WriteLine("Enter the Destination");
            travelLocation = Console.ReadLine();

            if(!(travelLocation.Equals("Mumbai") || travelLocation.Equals("Pune")))
            {
                goto dd;
            }

            ticketReservation obj = new ticketReservation(employeeId, employeeName, travelLocation);
            userData.Add(obj);
        }

        public void showTicket()
        {
            foreach(ticketReservation obj in userData)
            {
                Console.WriteLine("Name: {0}, Id: {1}, Location : {2}", obj._employeeName, obj._employeeId, obj._travelLocation);
            }
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            user us = new user();
            us.buyTicket();
            us.buyTicket();
            us.showTicket();
            Console.ReadKey();
        }
    }
}
