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

            Console.WriteLine("Hello user! Lets get started, shall we?");

            // Program Structs
            ProgramStrings.StringsMethod();
            Console.WriteLine(" ");
            ProgramInts.IntMethod();

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
