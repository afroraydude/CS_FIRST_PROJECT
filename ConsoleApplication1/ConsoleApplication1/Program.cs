﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            
            System.Console.WriteLine("Hello, World!");
            ProgramEnums.Days today = ProgramEnums.Days.Wednesday;
            int dayNumber = (int)today;
            Console.WriteLine("{0} is day number #{1}.", today, dayNumber);
            ProgramEnums.Months thisMonth = ProgramEnums.Months.Sep;
            byte monthNumber = (byte)thisMonth;
            Console.WriteLine("{0} is month number #{1}.", thisMonth, monthNumber);
            System.Console.WriteLine("Enter your first name.");
            ProgramStructs.Names.firstName = System.Console.ReadLine();
            System.Console.WriteLine("Enter your last name.");
            ProgramStructs.Names.lastName = System.Console.ReadLine();
            System.Console.Write("Your Name is " + ProgramStructs.Names.firstName + " " + ProgramStructs.Names.lastName);

            
            // So the program does not stop on its own
            Console.ReadKey();
            
            // Enter button only
            // Console.ReadLine();

            // Any Key
            //Console.ReadKey();

        }
    }
}