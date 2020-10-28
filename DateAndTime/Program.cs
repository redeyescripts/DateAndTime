using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine($"Today: {today}");
            int yearToday = today.Year;
            Console.WriteLine($"Current year from today {yearToday}");
            var weekDayToday = today.DayOfWeek;
            Console.WriteLine($" its {weekDayToday}!");
            Console.WriteLine("-------------");

            DateTime todayDetails = DateTime.Now;
            Console.WriteLine($"Today in details: {todayDetails}");
            DateTime utc = DateTime.UtcNow;
            Console.WriteLine($"UTC Tme {utc}");
            Console.ReadLine();

            DateTime christmasEvent = new DateTime(2020, 12, 24);
            var christmasDayOfWeek = christmasEvent.DayOfWeek;
            Console.WriteLine($"This years christmas eve is on {christmasDayOfWeek}");
            Console.ReadLine();
        }
    }
}
