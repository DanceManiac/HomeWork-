using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1

            Console.WriteLine("Введите число в диапазоне от 1 до 100:");
            
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number >= 1 && number <= 100)
                {
                    if (number % 3 == 0 && number % 5 == 0)
                        Console.WriteLine("FizzBuzz");
                    else if (number % 3 == 0)
                        Console.WriteLine("Fizz");
                    else if (number % 5 == 0)
                        Console.WriteLine("Buzz");
                    else
                        Console.WriteLine(number);
                }
                else
                    Console.WriteLine("Ошибка: введено число не в диапазоне от 1 до 100.");
            }
            else
                Console.WriteLine("Ошибка: введено не число.");

            // 2

            Console.WriteLine("Введите число:");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите процент:");
            double percent = double.Parse(Console.ReadLine());

            double result = number2 * percent / 100;

            Console.WriteLine("Результат: " + result);

            // 3

            Console.WriteLine("Введите четыре цифры:");

            int digit1 = int.Parse(Console.ReadLine());
            int digit2 = int.Parse(Console.ReadLine());
            int digit3 = int.Parse(Console.ReadLine());
            int digit4 = int.Parse(Console.ReadLine());

            int result2 = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;

            Console.WriteLine($"Результат: {result2}");
            Console.ReadLine();

            // 4

            Console.Write("Введите шестизначное число: ");
            int number3 = int.Parse(Console.ReadLine());

            if (number3 < 100000 || number3 > 999999)
            {
                Console.WriteLine("Ошибка: введено число не из диапазона 100000-999999");
                return;
            }

            Console.Write("Введите номера разрядов для обмена (например, 1 и 6): ");
            string input = Console.ReadLine();
            int firstIndex = int.Parse(input.Split(' ')[0]) - 1;
            int secondIndex = int.Parse(input.Split(' ')[1]) - 1;

            int[] digits = new int[6];

            for (int i = 0; i < 6; i++)
            {
                digits[i] = number3 % 10;
                number3 /= 10;
            }

            int temp = digits[firstIndex];
            digits[firstIndex] = digits[secondIndex];
            digits[secondIndex] = temp;

            int result3 = 0;

            for (int i = 5; i >= 0; i--)
            {
                result3 = result3 * 10 + digits[i];
            }

            Console.WriteLine($"Результат: {result3}");

            // 5

            Console.WriteLine("Введите дату в формате дд.мм.гггг, например 22.12.2021: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            string season = "";

            switch (date.Month)
            {
                case 12:
                case 1:
                case 2:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Fall";
                    break;
            }

            string dayOfWeek = date.DayOfWeek.ToString();

            Console.WriteLine("{0} {1}", season, dayOfWeek);

            // 6

            Console.Write("Введите температуру: ");
            double temperature = double.Parse(Console.ReadLine());

            Console.Write("Выберите, в какую систему перевести температуру (1 - Цельсия, 2 - Фаренгейты): ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                temperature = (temperature - 32) * 5 / 9;
                Console.WriteLine("Температура по Цельсию: " + temperature + "°C");
            }
            else if (choice == 2)
            {
                temperature = temperature * 9 / 5 + 32;
                Console.WriteLine("Температура по Фаренгейту: " + temperature + "°F");
            }
            else
                Console.WriteLine("Некорректный выбор.");

            Console.ReadKey();

            // 7

            Console.Write("Введите первое число: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int num2 = int.Parse(Console.ReadLine());

            int start, end;

            if (num1 <= num2)
            {
                start = num1;
                end = num2;
            }
            else
            {
                start = num2;
                end = num1;
            }

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
