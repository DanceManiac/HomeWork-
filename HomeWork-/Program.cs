using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPartsWarehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tovar> tovars = new List<Tovar>();

            int ID = 0;

            while (true)
            {
                Console.Write("Введите команду: ");
                string command = Console.ReadLine();

                if (command.StartsWith("ADD"))
                {
                    string[] parameters = command.Substring(4, command.Length - 5).Split(',');

                    if (parameters.Length == 4)
                    {
                        string invNum = parameters[0];
                        string name = parameters[1];
                        int cost;
                        int amount;

                        if (Int32.TryParse(parameters[2], out cost) && Int32.TryParse(parameters[3], out amount))
                        {
                            ID++;
                            Tovar tovar = new Tovar(ID, invNum, name, cost, amount);
                            tovars.Add(tovar);
                            Console.WriteLine($"Товар {tovar.ID} добавлен: {tovar.Name} ({tovar.InvNum}), стоимость {tovar.Cost} руб., количество на складе {tovar.Amount}");
                        }
                        else
                            Console.WriteLine("Некорректные параметры");
                    }
                    else
                        Console.WriteLine("Некорректные параметры");
                }
                else if (command == "SELECT *")
                {
                    Console.WriteLine("Список товаров:");

                    foreach (Tovar tovar in tovars)
                        Console.WriteLine($"ID: {tovar.ID}, Инвентарный номер: {tovar.InvNum}, Наименование: {tovar.Name}, Стоимость: {tovar.Cost} руб., Количество на складе: {tovar.Amount}");
                }
                else
                    Console.WriteLine("Неизвестная команда");
            }
        }
    }

    class Tovar
    {
        public int ID;
        public string InvNum;
        public string Name;
        public int Cost;
        public int Amount;

        public Tovar(int id, string invNum, string name, int cost, int amount)
        {
            ID = id;
            InvNum = invNum;
            Name = name;
            Cost = cost;
            Amount = amount;
        }
    }
}
