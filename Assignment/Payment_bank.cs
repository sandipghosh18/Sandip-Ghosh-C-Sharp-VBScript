using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_App
{

    class bankData
    {
        private int accountNumber;
        private String customerName;
        private String customerEmailId;
        private double accountBalance;

        public bankData(int accountNumber,String customerName,String customerEmailId,double accountBalance)
        {
            this.accountNumber = accountNumber;
            this.customerName = customerName;
            this.customerEmailId = customerEmailId;
            this.accountBalance = accountBalance;
        }

        public int _accountNumber
        {
            get { return accountNumber; }
        }

        public String _customerName
        {
            get { return customerName; }
        }

        public String _customerEmailId
        {
            get { return customerEmailId; }
        }
        public double _accoutBalance
        {
            get { return accountBalance; }
        }
    }

    class bankOperation
    {
        List<bankData> banktable = new List<bankData>();
        Hashtable bankT = new Hashtable();
        

        public void createAccount()
        {
            Random rd = new Random();
            int accountNumber = rd.Next();

            Console.WriteLine("Enter your full name");
            String name = Console.ReadLine();

            Console.WriteLine("Enter your mailId");
            String mail = Console.ReadLine();

            Console.WriteLine("Enter your first Deposit balance");
            double balance = Convert.ToInt32(Console.ReadLine());

            bankData bnkd = new bankData(accountNumber, name, mail, balance);
            bankT.Add(accountNumber, bnkd);

            Console.WriteLine("Bank account sucesfully Created!");
            
        }

        public bool checkAccountNumber(int accountNumber)
        {

            return bankT.ContainsKey(accountNumber);
            
            
        }

        public void displayAccountDetails()
        {
            Console.WriteLine("Enter the account number");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            ICollection cl = bankT.Keys;
            
            

            
                

            
        }
        
    }




    class Program
    {
        static void Service()
        {
            Console.WriteLine("Welcome to Sandy payment bank");
            bankOperation bo = new bankOperation();

            while (true)
            {
                Console.WriteLine("operation menu");
                Console.WriteLine("1: Create a new account");
                Console.WriteLine("2: Display account details");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        bo.createAccount();
                        break;
                    case 2:
                        bo.displayAccountDetails();
                        break;
                    case 3:
                        break;
                    default:
                        break;

                }
            }
        }
        static void Main(string[] args)
        {
            Service();
            Console.ReadKey();
        }
    }
}
/**Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Account Number:{0}",de.Value);
                Console.WriteLine("Full Name: {0}", bd._customerName);
                Console.WriteLine("Email: {0}", bd._customerEmailId);
                Console.WriteLine("Account Balance: {0}", bd._accoutBalance);
                Console.WriteLine("------------------------------------------------");***/
