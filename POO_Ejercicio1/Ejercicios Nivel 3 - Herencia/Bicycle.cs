using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    protected string color;

    public Car(string color)
    {
        this.color = color;
    }

    public void Advance()
    {
        Console.WriteLine($"The car is {color} and is advance");
    }
}

public class Bicycle : Car
{
    public Bicycle(string color) : base(color) { }

    public void Pedalear()
    {
        Console.WriteLine($"The bicycle is {color} and pedal");
    }
}
