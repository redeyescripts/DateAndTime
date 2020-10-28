using System;

namespace BirthDayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year are you born in?");
        
            string UserInput;
            UserInput = Console.ReadLine();
            int Year;
            Year = Int32.Parse(UserInput);
            int Age = 2020 - Year;
            Console.WriteLine("You are " + Age + " old.");

            Console.WriteLine("What month are you born in?");
            string Month;
            Month = Console.ReadLine();
            int month;
            month = Int32.Parse(UserInput);
            Console.WriteLine("You are born in " + Month + ".");
            Console.ReadLine();
        }
    }
}
