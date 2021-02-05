using System;

namespace WorkingWithDatesAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDateAndTime=DateTime.Now;
            Console.WriteLine(currentDateAndTime);
            var currentShortTime=DateTime.Now.ToShortTimeString();
            Console.WriteLine(currentShortTime);
            var currentLongTime=DateTime.Now.ToLongTimeString();
            Console.WriteLine(currentLongTime);
            var currentShortDate=DateTime.Now.ToShortDateString();
            
            Console.WriteLine(currentShortDate);
            var currentLongDate=DateTime.Now.ToLongDateString();
            Console.WriteLine(currentLongDate);

            var fifteenYearsAgo=DateTime.Now.AddYears(-15);
            Console.WriteLine(fifteenYearsAgo.DayOfWeek);

            var fifteenYearsToCome=DateTime.Now.AddYears(15);
            Console.WriteLine(fifteenYearsToCome.DayOfWeek);
        }
    }
}
