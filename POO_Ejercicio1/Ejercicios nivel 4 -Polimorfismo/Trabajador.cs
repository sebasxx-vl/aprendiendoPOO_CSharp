using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Trabajador
{
    protected string nombre;

    public Trabajador(string nombre)
    {
        this.nombre = nombre;
    }

    public virtual void Trabajar()
    {
        Console.WriteLine($"{nombre} está trabajando");
    }
}

public class Desarrollador : Trabajador
{
    public Desarrollador(string nombre) : base(nombre) { }

    public override void Trabajar()
    {
        Console.WriteLine($"{nombre} está escribiendo código");
    }
}

public class Diseñador : Trabajador
{
    public Diseñador(string nombre) : base(nombre) { }

    public override void Trabajar()
    {
        Console.WriteLine($"{nombre} está diseñandi interfaces");
    }
}