using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
	
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int id = 2453;
            String name = "Sandip";
            Char gender = 'M';
            float percentage = 75.50F;
            Byte age = 32;

            //Display

            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Percentage: {0:F2}",percentage);
            Console.WriteLine("ID: {0} Name: {1} Age: {2}", id,name,age);

            Console.ReadKey();


        }
    }
}
