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
        }

        struct Ints
        {
            // user age
            public static int age;

            public static int bMonth;

            public static int bDay;

            public static int bYear;
            public static int bDayLiving;

        }

    }
}
