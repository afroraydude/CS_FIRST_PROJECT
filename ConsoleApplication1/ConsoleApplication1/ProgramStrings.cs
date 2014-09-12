using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace ConsoleApplication1
{
    class ProgramStrings
    {
        // Code to execute
        public static void StringsMethod()
        {
            System.Console.WriteLine("Enter your first name.");
            Strings.firstName = System.Console.ReadLine();
            System.Console.WriteLine("Enter your last name.");
            Strings.lastName = System.Console.ReadLine();
            System.Console.WriteLine("Your Name is " + Strings.firstName + " " + Strings.lastName + ".");
            Strings.fullName = Strings.firstName + " " + Strings.lastName;
        }
        
        struct Strings
        {

            // user's first name
            public static string firstName; 

            // user's last name
            public static string lastName;

            // user's full name
            public static string fullName;

        }

    }

}
