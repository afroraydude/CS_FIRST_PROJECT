using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Web.Services.Description;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        /// <summary>
        /// Main Class for program
        /// </summary>
        static void Main()
        {
            /// <summary>
            /// User's first name
            /// </summary>
            string firstName; 

            /// <summary>
            /// User's last name
            /// </summary>
            string lastName;

            /// <summary>
            /// User's last name
            /// </summary>
            string fullName;
            Console.WriteLine("Hello user! Lets get started, shall we?");
            
            // Finds the user's names, to be used again...somewhere
            System.Console.WriteLine("Enter your first name.");
            firstName = System.Console.ReadLine();
            System.Console.WriteLine("Enter your last name.");
            lastName = System.Console.ReadLine();
            fullName = firstName + " " + lastName;
            System.Console.WriteLine("Your Name is " + fullName);
            
            Thread.Sleep(1000);

            Console.Write("Enter your birthday (YYYY-MM-DD): ");
            DateTime birthday = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime now = DateTime.Now.Date;
            Console.Write(String.Format("You are {0} days old.", (now - birthday).TotalDays));
            Console.ReadLine();

            // So the program does not stop on its own
            System.Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            

            // Enter button only
            // Console.ReadLine();

            // Any Key
            //Console.ReadKey();

        }
    }
}
