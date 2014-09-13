using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ProgramInts
    {

        /// <summary>
        /// All code not in Ints goes here.
        /// </summary>
        public static void IntMethod()
        {
            Console.WriteLine("Enter your age(as number)");
            Ints.age = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter your birth month (as a number).");
            Ints.bMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your birth day (not year or month).");
            Ints.bDay = Convert.ToInt32(Console.ReadLine());
            
            DateTime dt = DateTime.Now;

            Ints.bYear = Ints.curYear - Ints.age;

            Console.WriteLine("Your age is " + Ints.age + " and you were born on/around " + Ints.bMonth + "/" + Ints.bDay + "/" + Ints.bYear);

            Ints.Years = Ints.curYear - Ints.bYear - 1; 
            
            Ints.YearDay = Ints.Years * 365;

            // Bacically calculates age in days

            Ints.bMonthNov = (dt.Month / 11 == 1);
            Ints.bMonthDec = (dt.Month / 12 == 1);
            Ints.bMonthOct = (dt.Month / 10 == 1);
            Ints.bMonthSep = (dt.Month / 9 == 1);
            Ints.bMonthAug = (dt.Month / 8 == 1);
            Ints.bMonthJul = (dt.Month / 7 == 1);
            Ints.bMonthJun = (dt.Month / 6 == 1);
            Ints.bMonthMay = (dt.Month / 5 == 1);
            Ints.bMonthApr = (dt.Month / 4 == 1);
            Ints.bMonthMar = (dt.Month / 3 == 1);
            Ints.bMonthJan = (dt.Month / 1 == 1);
            Ints.bMonthFeb = (dt.Month / 2 == 1);
            
            if(Ints.bMonthFeb)
            {
                Ints.curMonthDay = 28;
                Ints.bDayLiving = Ints.YearDay + 59;
            }
            else
            {
               
            }

            if (Ints.bMonthJan)
            {
                Ints.curMonthDay = 31;
                Ints.bDayLiving = Ints.YearDay + 31;
            }
            else
            {
                
            }

            if (Ints.bMonthMar)
            {
                Ints.curMonthDay = 31;
                Ints.bDayLiving = Ints.YearDay + 90;
            }
            else
            {
                
            }

            if (Ints.bMonthApr)
            {
                Ints.curMonthDay = 30;
                Ints.bDayLiving = Ints.YearDay + 120;
            }
            else
            {
                
            }

            if (Ints.bMonthMay)
            {
                Ints.curMonthDay = 31;
                Ints.bDayLiving = Ints.YearDay + 151;
            }
            else
            {
                
            }

            if (Ints.bMonthJun)
            {
                Ints.curMonthDay = 30;
                Ints.bDayLiving = Ints.YearDay + 181;
            }
            else
            {
                
            }

            if (Ints.bMonthJul)
            {
                Ints.curMonthDay = 31;
                Ints.bDayLiving = Ints.YearDay + 212;
            }
            else
            {
                
            }

            if (Ints.bMonthAug)
            {
                Ints.curMonthDay = 31;
                Ints.bDayLiving = Ints.YearDay + 243;
            }
            else
            {
                
            }

            if (Ints.bMonthSep)
            {
                Ints.curMonthDay = 30;
                Ints.bDayLiving = Ints.YearDay + 273;
            }
            else
            {
                
            }

            if (Ints.bMonthOct)
            {
                Ints.curMonthDay = 31;
                Ints.bDayLiving = Ints.YearDay + 304;
            }
            else
            {
                
            }

            if (Ints.bMonthNov)
            {
                Ints.curMonthDay = 30;
                Ints.bDayLiving = Ints.YearDay + 334;
            }
            else
            {
                
            }

            if (Ints.bMonthDec)
            {
                Ints.curMonthDay = 31;
                Ints.bDayLiving = Ints.YearDay + 365;
            }
            else
            {
                
            }

            
            
        }

        public struct Ints
        {

            /// <summary>
            /// User's age
            /// </summary>
            public static int age;
            /// <summary>
            /// Birth Month
            /// </summary>
            public static int bMonth;
            /// <summary>
            /// User's birth day
            /// </summary>
            public static int bDay;
            /// <summary>
            /// Birth Year (calculated)
            /// </summary>
            public static int bYear;
            /// <summary>
            /// I really don't know what this is
            /// </summary>
            public static int MonthDay;
            /// <summary>
            /// User's days living, minus leap days, plus days in month after birth day in current year, plus days before birth date.
            /// </summary>
            public static int bDayLiving;
            /// <summary>
            /// Days before birth
            /// </summary>
            public static int daysBeforeBirth;
            /// <summary>
            /// Current Month in days
            /// </summary>
            public static int curMonthDay;
            /// <summary>
            /// curYear - bYear
            /// </summary>
            public static int Years;
            /// <summary>
            /// Current Year
            /// </summary>
            public static int curYear;
            /// <summary>
            /// The year in days
            /// </summary>
            public static int YearDay;
            
            // TODO: Move to new ProgramBools.cs file
            public static bool bMonthJan = true;
            public static bool bMonthFeb = true;
            public static bool bMonthMar = true;
            public static bool bMonthApr = true;
            public static bool bMonthMay = true;
            public static bool bMonthJun = true;
            public static bool bMonthJul = true;
            public static bool bMonthAug = true;
            public static bool bMonthSep = true;
            public static bool bMonthOct = true;
            public static bool bMonthNov = true;
            public static bool bMonthDec = true;
            /// <summary>
            /// Days before today
            /// </summary>
            public static int DaysBeforeToday;
            /// <summary>
            /// What is this?
            /// </summary>
            public static bool MonthDaysToday;
            
        }

    }
}
