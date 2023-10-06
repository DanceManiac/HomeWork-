using System;
using System.Collections.Generic;
using Calendar.Core;
using Calendar.Data;

namespace Calendar.UI
{
    internal class CalendarUI
    {
        static void Main(string[] args)
        {
            CalendarManager calendarManager = new CalendarManager();
            CalendarData calendarData = new CalendarData();

            Dictionary<DateTime, string> specialDates = calendarData.LoadSpecialDates();

            while (true)
            {
                Console.WriteLine("Календарь с особыми датами");
                Console.WriteLine("1. Показать календарь");
                Console.WriteLine("2. Добавить особую дату");
                Console.WriteLine("3. Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        calendarManager.ShowCalendar(specialDates);
                        break;
                    case "2":
                        calendarManager.AddSpecialDate(specialDates);
                        calendarData.SaveSpecialDates(specialDates);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите 1, 2 или 3.");
                        break;
                }
            }
        }
    }
}
