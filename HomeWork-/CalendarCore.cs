using System;
using System.Collections.Generic;

namespace Calendar.Core
{
    public class CalendarManager
    {
        public void ShowCalendar(Dictionary<DateTime, string> specialDates)
        {
            Console.WriteLine("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите месяц (1-12): ");
            int month = int.Parse(Console.ReadLine());

            DateTime currentDate = new DateTime(year, month, 1);
            DateTime lastDayOfMonth = currentDate.AddMonths(1).AddDays(-1);

            Console.WriteLine($"Календарь на {currentDate:MMMM yyyy}:");
            Console.WriteLine("Пн Вт Ср Чт Пт Сб Вс");

            for (int i = 1; i < (int)currentDate.DayOfWeek; i++)
                Console.Write("   ");

            while (currentDate <= lastDayOfMonth)
            {
                string dayInfo = "";

                if (specialDates.ContainsKey(currentDate))
                    dayInfo = specialDates[currentDate];

                Console.Write($"{currentDate.Day:D2} {dayInfo,-2} ");

                if (currentDate.DayOfWeek == DayOfWeek.Sunday)
                    Console.WriteLine();

                currentDate = currentDate.AddDays(1);
            }

            Console.WriteLine();
        }

        public void AddSpecialDate(Dictionary<DateTime, string> specialDates)
        {
            Console.WriteLine("Введите дату (гггг-мм-дд): ");

            if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                Console.WriteLine("Введите описание: ");
                string description = Console.ReadLine();
                specialDates[date] = description;
                Console.WriteLine("Особая дата добавлена!");
            }
            else
                Console.WriteLine("Некорректный формат даты.");
        }
    }
}