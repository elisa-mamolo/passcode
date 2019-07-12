using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassCode
{
    //my first c# program
    class Program
    {
        static void Main(string[] args)
        {
            var code = "";
            // if code is not secret it will keep lookping so the
            // no access result will forward to another question 
            while (code != "password")
            { 
            
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("What is the passcode?");
            code = Console.ReadLine();
           
            if ( code != "password")
                {
                    Console.WriteLine(" NOT Authenticated ");
                }
        }
            Console.WriteLine("Authenticated");

        }
}
}
