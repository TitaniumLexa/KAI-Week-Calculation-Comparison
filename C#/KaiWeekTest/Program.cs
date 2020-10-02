using System;
using System.Globalization;

namespace KaiWeekTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;

            int startYear = 2020;
            int yearsCount = 10;

            for (int i = 0; i < yearsCount; i++)
            {
                DateTime date = new DateTime(startYear + i, 9, 1, 12, 0, 0);
                int weekNum = cal.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
                bool even = (weekNum - 1) % 2 == 0;
                string week = (even ? "" : "НЕ") + "ЧЕТНАЯ НЕДЕЛЯ";

                Console.WriteLine($"{date} - {weekNum} -> {week}");
            }
        }
    }
}
