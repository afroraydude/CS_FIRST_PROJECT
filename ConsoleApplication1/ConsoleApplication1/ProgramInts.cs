using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ProgramInts
    {

        public static void IntMethod()
        {
            Console.WriteLine("Enter your age(as number)");
            Ints.age = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter your birth month (as a number).");
            Ints.bMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your birth day (not year or month).");
            Ints.bDay = Convert.ToInt32(Console.ReadLine());
            
            DateTime dt = DateTime.Now;

            Ints.bYear = dt.Year - Ints.age;

            Console.WriteLine("Your age is " + Ints.age + " and you were born on/around " + Ints.bMonth + "/" + Ints.bDay + "/" + Ints.bYear);

            Ints.bMonthFeb = (Ints.bMonth / 2 == 1);
            if (Ints.bMonthFeb)
            {
                Ints.MonthDay = 28;
            }
            else
            {
                return;
            }

            Ints.bMonthJan = (Ints.bMonth / 1 == 1);
            if (Ints.bMonthJan)
            {
                Ints.MonthDay = 31;
            }
            else
            {
                return;
            }

            Ints.bMonthMar = (Ints.bMonth / 3 == 1);
            if (Ints.bMonthMar)
            {
                Ints.MonthDay = 31;
            }
            else
            {
                return;
            }

            Ints.bMonthApr = (Ints.bMonth / 5 == 1);
            if (Ints.bMonthApr)
            {
                Ints.MonthDay = 30;
            }
            else
            {
                return;
            }

            Ints.bMonthMay = (Ints.bMonth / 5 == 1);
            if (Ints.bMonthMay)
            {
                Ints.MonthDay = 31;
            }
            else
            {
                return;
            }

            Ints.bMonthJun = (Ints.bMonth / 6 == 1);
            if (Ints.bMonthJun)
            {
                Ints.MonthDay = 30;
            }
            else
            {
                return;
            }

            Ints.bMonthJul = (Ints.bMonth / 7 == 1);
            if (Ints.bMonthJul)
            {
                Ints.MonthDay = 31;
            }
            else
            {
                return;
            }

            Ints.bMonthAug = (Ints.bMonth / 8 == 1);
            if (Ints.bMonthAug)
            {
                Ints.MonthDay = 31;
            }
            else
            {
                return;
            }

            Ints.bMonthSep = (Ints.bMonth / 9 == 1);
            if (Ints.bMonthSep)
            {
                Ints.MonthDay = 30;
            }
            else
            {
                return;
            }

            Ints.bMonthOct = (Ints.bMonth / 10 == 1);
            if (Ints.bMonthOct)
            {
                Ints.MonthDay = 31;
            }
            else
            {
                return;
            }

            Ints.bMonthNov = (Ints.bMonth / 11 == 1);
            if (Ints.bMonthNov)
            {
                Ints.MonthDay = 30;
            }
            else
            {
                return;
            }

            Ints.bMonthDec = (Ints.bMonth / 12 == 1);
            if (Ints.bMonthDec)
            {
                Ints.MonthDay = 31;
            }
            else
            {
                return;
            }

            Ints.daysBeforeBirth = Ints.MonthDay - Ints.bDay;

        }

        struct Ints
        {

            public static int age;
            public static int bMonth;
            public static int bDay;
            public static int bYear;
            public static int MonthDay;
            public static int bDayLiving;
            public static int daysBeforeBirth;

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

        }

    }
}
