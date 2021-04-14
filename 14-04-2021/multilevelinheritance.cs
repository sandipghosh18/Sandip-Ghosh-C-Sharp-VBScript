using System;
using System.IO;

namespace Day2
{
    public class Emp
    {
        private int eid;
        private string ename;
        protected float bsal;

        public string getEmp(int eid, string ename, float bsal)
        {
            this.eid = eid;
            this.ename = ename;
            this.bsal = bsal;
            return ename + " " + eid + " " + bsal;
        }
        public void dispEmp(string emp)
        {
            Console.WriteLine("Employee Details: " + emp);
        }
    }

    public class Allow : Emp
    {
        private int da = 10;
        private int hra = 12;
        private int ta = 400;
        protected float gross;

        public void getGross()
        {
            gross = bsal * (1 + (float)da / 100 + (float)hra / 100) + ta;
        }
        public void dispGross()
        {
            Console.WriteLine("Gross Sal: " + gross);
        }
    }

    public class Net : Allow
    {
        private int ptax = 10;
        private int itax = 12;
        private int pf = 1000;
        private float net;

        public void getNet()
        {
            net = gross * (1 - (float)ptax / 100 - (float)itax / 100) - 1000;
        }

        public void dispNet()
        {
            Console.WriteLine("Net sal: " + net);
        }
    }

    public class Exec
    {
        static void Main(string[] args)
        {
            Net net = new Net();
            string emp = net.getEmp(10, "Sandip", 20000.00F);
            net.dispEmp(emp);
            net.getGross();
            net.dispGross();
            net.getNet();
            net.dispNet();

            Console.ReadKey();
        }
    }
}
