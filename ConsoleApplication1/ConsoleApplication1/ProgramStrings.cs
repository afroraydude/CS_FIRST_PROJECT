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
        /// <summary>
        /// All code not in Strings goes here
        /// </summary>
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

            /// <summary>
            /// User's first name
            /// </summary>
            public static string firstName; 

            /// <summary>
            /// User's last name
            /// </summary>
            public static string lastName;

            /// <summary>
            /// User's last name
            /// </summary>
            public static string fullName;

        }

    }

}
