using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Calendar.Data
{
    public class CalendarData
    {
        private static string dataFilePath = "specialDates.dat";
        public Dictionary<DateTime, string> LoadSpecialDates()
        {
            if (File.Exists(dataFilePath))
            {
                try
                {
                    using (FileStream fileStream = new FileStream(dataFilePath, FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        return (Dictionary<DateTime, string>)formatter.Deserialize(fileStream);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка при загрузке данных: " + ex.Message);
                }
            }

            return new Dictionary<DateTime, string>();
        }

        public void SaveSpecialDates(Dictionary<DateTime, string> specialDates)
        {
            try
            {
                using (FileStream fileStream = new FileStream(dataFilePath, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, specialDates);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при сохранении данных: " + ex.Message);
            }
        }
    }
}
