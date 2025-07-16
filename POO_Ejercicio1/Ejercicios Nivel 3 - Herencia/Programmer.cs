using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee
{
    protected string name;

    public Employee(string name)
    {
        this.name = name;
    }

    public void Work()
    {
        Console.WriteLine($"{name} is working");
    }
}

public class Programmer : Employee
{
    public Programmer(string name) : base(name) { }

    public void CodeWrite()
    {
        Console.WriteLine($"{name} this programming in the C# language");
    }
}