using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Web.Services.Description;

namespace ConsoleApplication1
{
    class Program
    {
        /// <summary>
        /// Main Class for program
        /// </summary>
        static void Main()
        {

            DateTime adt = DateTime.Now;
            ProgramInts.Ints.curYear = adt.Year;

            Console.WriteLine("Hello user! Lets get started, shall we?");

            // Program Structs
            ProgramStrings.StringsMethod();
            Console.WriteLine(" ");
            ProgramInts.IntMethod();
            
            Thread.Sleep(1000);
            Console.WriteLine("And you have been alive for about " + ProgramInts.Ints.bDayLiving + " days total.");

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
