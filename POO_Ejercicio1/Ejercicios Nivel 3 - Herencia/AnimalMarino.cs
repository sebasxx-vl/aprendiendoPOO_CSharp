using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AnimalMarino
{
    protected string nombre;

    public AnimalMarino(string nombre)
    {
        this.nombre = nombre;
    }

    public void Nadar()
    {
        Console.WriteLine($"El animal marino {nombre} está nadando");
    }
}

public class Delfin : AnimalMarino
{
    public Delfin(string nombre) : base(nombre) { }

    public void HacerSonido()
    {
        Console.WriteLine($"El {nombre} está haciendo sonidos característicos");
    }
}