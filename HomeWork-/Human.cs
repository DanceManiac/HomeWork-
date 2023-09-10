using System;
using System.Collections.Generic;

public class Human
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public Human Parent1 { get; set; }
    public Human Parent2 { get; set; }

    private static List<Human> humans = new List<Human>();

    public Human(string name, string gender, int age)
    {
        Name = name;
        Gender = gender;
        Age = age;
        humans.Add(this);
    }

    public static Human CreateHuman(string name, string gender, int age, Human parent1 = null, Human parent2 = null)
    {
        Human human = new Human(name, gender, age);
        human.Parent1 = parent1;
        human.Parent2 = parent2;
        return human;
    }

    public static int GetCount()
    {
        return humans.Count;
    }

    public static string GetAllInfo()
    {
        string info = "";
        foreach (Human human in humans)
        {
            info += $"Name: {human.Name}, Gender: {human.Gender}, Age: {human.Age}\n";
            if (human.Parent1 != null)
                info += $"Parent 1: {human.Parent1.Name}\n";
            if (human.Parent2 != null)
                info += $"Parent 2: {human.Parent2.Name}\n";
            info += "\n";
        }
        return info;
    }
}
