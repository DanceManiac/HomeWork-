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
            Human parent1 = new Human("Father", "male", 50);
            Human parent2 = new Human("Mother", "female", 45);
            Human.CreateHuman("Child1", "male", 20, parent1, parent2);
            Human.CreateHuman("Child2", "female", 18, parent1, parent2);
            Human.CreateHuman("Child3", "male", 15, parent1, parent2);
            Human.CreateHuman("Child4", "female", 12, parent1, parent2);
            Human.CreateHuman("Child5", "male", 5);

            Console.WriteLine($"Total number of humans: {Human.GetCount()}\n");

            Console.WriteLine(Human.GetAllInfo());
        }
    }
}
