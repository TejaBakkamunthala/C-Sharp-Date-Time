using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DateTime1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime now = DateTime.Now;
            Console.WriteLine("Now "+now);
            DateTime dt = new DateTime();
            Console.WriteLine(dt);

            DateTime min= DateTime.MinValue;
            Console.WriteLine("Min "+min);

            DateTime max= DateTime.MaxValue;
            Console.WriteLine("Max "+max);

            DateTime dt3=DateTime.Now;
            Console.WriteLine("INDIAN TIME ");
            DateTime dt1=DateTime.Now;
            Console.WriteLine("Date "+dt1.Date);
            Console.WriteLine("Time "+dt1.TimeOfDay);
            Console.WriteLine("Day "+dt1.Day);
            Console.WriteLine("month "+dt1.Month);
            Console.WriteLine("Year "+dt1.Year);

            Console.WriteLine("INTERNATIONAL ");
            DateTime dt2 = DateTime.UtcNow;
            Console.WriteLine("Date "+dt2.Date);
            Console.WriteLine("Time "+dt2.TimeOfDay);
            Console.WriteLine("Day "+dt2.Day);
            Console.WriteLine("Day "+dt2.DayOfWeek);
            Console.WriteLine("Month "+dt2.Month);
            Console.WriteLine("Year "+dt2.Year);

            Console.WriteLine(dt1.Kind);
            Console.WriteLine(dt2.Kind);

            Console.WriteLine(dt1.ToUniversalTime());
            Console.WriteLine(dt2.ToLocalTime());


            Console.WriteLine(now);
            Console.WriteLine("Add Minutes "+dt1.AddMinutes(2));
            Console.WriteLine("Add Hours " + dt1.AddHours(2));
            Console.WriteLine("Add Days "+dt1.AddDays(2));
            Console.WriteLine("Add Months "+dt1.AddMonths(2));
            Console.WriteLine("Add years "+dt1.AddYears(2));

            Console.WriteLine("Remove hOURS "+dt1.AddHours(-2));
            Console.WriteLine("Remove Days "+dt1.AddDays(-2));
            Console.WriteLine("REmove Months "+dt1.AddMonths(-2));
            Console.WriteLine("Remove Years "+dt1.AddYears(-2));


            Console.WriteLine("Time Difference "+dt1.Subtract(dt2));

            Console.WriteLine("Compare "+dt1.CompareTo(dt2));

            Console.WriteLine("Compare "+dt2.CompareTo(dt1));

            Console.WriteLine("Compare "+dt1.CompareTo(dt3));


            Console.WriteLine("FORMAT ");

            Console.WriteLine(dt1.ToString("d"));
            Console.WriteLine(dt1.ToString("D"));

            Console.WriteLine(dt1.ToString("t"));
            Console.WriteLine(dt1.ToString("T"));
            Console.WriteLine(dt1.ToString("o"));
            Console.WriteLine(dt1.ToString("f"));
            Console.WriteLine(dt1.ToString("F"));
            Console.WriteLine(dt1.ToString("g"));

            Console.WriteLine(dt1.ToString("G"));

            Console.WriteLine(dt1.ToString("M"));
            Console.WriteLine(dt1.ToString("MM"));
            Console.WriteLine(dt1.ToString("MMM"));
            Console.WriteLine(dt1.ToString("MMMM"));
            Console.WriteLine(dt1.ToString("R"));
            Console.WriteLine(dt1.ToString("s"));
           Console.WriteLine(dt1.ToString("hh"));
            Console.WriteLine(dt1.ToString("HH"));
            Console.WriteLine(dt1.ToString("y"));
            Console.WriteLine(dt1.ToString("yy")); 
            Console.WriteLine(dt1.ToString("yyy"));

            Console.WriteLine("cutsom");

            Console.WriteLine(dt1.ToString("MMM dd ,yyyy hh:mm:ss tt"));
            Console.WriteLine(dt1.ToString("MMM dd yyyy hh:mm:ss tt"));
            Console.WriteLine(dt1.ToString("MMM-dd-yyyy HH:MM:ss TT"));
            Console.WriteLine(dt1.ToString("MMM/dd/yyyy HH:MM:ss TT"));
            Console.WriteLine(dt1.ToString("MM-dd-yyyy"));


            DateTime dt4 = DateTime.Parse("28-04-2024");
            Console.WriteLine(dt4);

            DateTime dt5 = DateTime.Parse("28.04.2024");
            Console.WriteLine(dt5);




            Console.WriteLine();









        }
    }
}
