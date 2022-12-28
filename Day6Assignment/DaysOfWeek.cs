using System;

namespace Day6Assignment
{
    class DayOfWeek
    {
        public static void Days(){
            System.Console.WriteLine("Enter month");
            int m = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter date");
            int d = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter year");
            int y = Convert.ToInt32(Console.ReadLine());


            int y1 = y - ((14 - m) / 12);
            int x = y1 + (y1 / 4) - (y1 / 100) + (y1 / 400);
            int m1 = m + (12 * ((14 - m) / 12)) - 2;
            int d1 = (d + x + ((31 * m1) / 12)) % 7;

            string[] days = { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };

            System.Console.WriteLine("Day = "+days[d1]);
        }
    }
}