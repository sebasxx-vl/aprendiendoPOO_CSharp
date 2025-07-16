using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Instrument
{
    protected string type;

    public Instrument(string type)
    {
        this.type = type;
    }

    public void Tune()
    {
        Console.WriteLine($"Tuning instrument the type {type}");
    }
}

public class Guitar : Instrument
{
    public Guitar(string type) : base(type) { }

    public void Play()
    {
        Console.WriteLine($"Playing the {type} guitar");
    }
}