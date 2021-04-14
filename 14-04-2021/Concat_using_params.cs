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
    class paramdemo
    {
        public String array(params String[] arr)
        {
            String str = "";
            foreach(String s in arr)
            {
                str += s;
            }
            return str;
        }
        
        
    }
    
    
    class StudentTest
    {
        static void Main(string[] args)
        {
            paramdemo pd = new paramdemo();
           String st= pd.array("sandip", "ghosh", "aditi");
            Console.WriteLine(st);
            
            Console.ReadKey();
            
            
        }

    }
}
