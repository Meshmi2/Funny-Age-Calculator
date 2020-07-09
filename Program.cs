using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FunnyAgeCalculator
{
    class Program
    {
        private static object interval;

        static void Main(string[] args)
        {
            // Define Your Birthday
            Console.WriteLine("please input your birthday YEAR");
            Thread.Sleep(750);
            int Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please input your birthday MONTH");
            Thread.Sleep(750);
            int Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please input your birthday DAY");
            Thread.Sleep(750);
            int Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please input your birthday HOURS");
            int Hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please input your birthday MINUTES");
            Thread.Sleep(750);
            int Minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please input your birthday SECOND");
            Thread.Sleep(750);
            int Second = Convert.ToInt32(Console.ReadLine());
            // Define Birthday And Now Date
            DateTime birthday = new DateTime(Year, Month, Day, Hours, Minutes, Second);
            DateTime now = DateTime.Now;
            // Calculate The Interval Between The Two Day
            TimeSpan interval = now - birthday;
            Console.WriteLine("{0} - {1} = {2}", now, birthday, interval.ToString());
            // Display Days,Hours,Minutes,Second,Millisecond...
            Thread.Sleep(750);
            Console.WriteLine("   {0,-35} {1,20}", "You have...", interval.TotalDays +"Days");
            Thread.Sleep(750);
            Console.WriteLine("   {0,-35} {1,20}", "You have...", interval.TotalHours + "Hours");
            Thread.Sleep(750);
            Console.WriteLine("   {0,-35} {1,20}", "You have...", interval.TotalMinutes+ "Minutes");
            Thread.Sleep(750);
            Console.WriteLine("   {0,-35} {1,20:N0}", "You have...", interval.TotalSeconds+ "Second");
            Thread.Sleep(750);
            Console.WriteLine("   {0,-35} {1,20:N0}", "You have...", interval.TotalMilliseconds+ "Millisecond");
            Thread.Sleep(90000);


        }

    }
}
