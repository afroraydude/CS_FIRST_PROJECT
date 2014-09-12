using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Web.Services.Description;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Hello, World!");
            ProgramEnums.Days today = ProgramEnums.Days.Wednesday;
            int dayNumber = (int)today;
            Console.WriteLine("{0} is day number #{1}.", today, dayNumber);
            ProgramEnums.Months thisMonth = ProgramEnums.Months.Sep;
            byte monthNumber = (byte)thisMonth;
            Console.WriteLine("{0} is month number #{1}.", thisMonth, monthNumber);

            // Program Structs
            ProgramStrings.StringsMethod();
            Console.WriteLine("Lets open another class.");
            ProgramInts.IntMethod();

            // So the program does not stop on its own
            Console.ReadKey();
            
            // Enter button only
            // Console.ReadLine();

            // Any Key
            //Console.ReadKey();

        }
    }
}
