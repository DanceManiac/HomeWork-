using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Money
{
    private int dollars;
    private int cents;

    public Money(int dollars, int cents)
    {
        this.dollars = dollars;
        this.cents = cents;
    }

    public void Display()
    {
        Console.WriteLine($"Сумма: {dollars} долларов и {cents} центов");
    }

    public void SetAmount(int dollars, int cents)
    {
        this.dollars = dollars;
        this.cents = cents;
    }

    public int Dollars
    {
        get { return dollars; }
        set { dollars = value; }
    }

    public int Cents
    {
        get { return cents; }
        set { cents = value; }
    }
}

public class Product
{
    private string name;
    private Money price;

    public Product(string name, int dollars, int cents)
    {
        this.name = name;
        this.price = new Money(dollars, cents);
    }

    public void ReducePrice(int reductionDollars, int reductionCents)
    {
        int newDollars = price.Dollars - reductionDollars;
        int newCents = price.Cents - reductionCents;

        if (newCents < 0)
        {
            newDollars--;
            newCents += 100;
        }

        price.SetAmount(newDollars, newCents);
    }

    public void Display()
    {
        Console.WriteLine($"Название товара: {name}");
        price.Display();
    }
}

namespace HomeWork_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money(50, 75);
            Product product = new Product("Шоколадка", 5, 50);

            money.Display();
            product.Display();

            product.ReducePrice(2, 25);

            money.Display();
            product.Display();
        }
    }
}
