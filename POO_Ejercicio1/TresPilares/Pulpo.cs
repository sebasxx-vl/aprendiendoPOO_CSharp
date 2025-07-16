using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Marino
{
    protected string nombre;

    public Marino(string nombre)
    {
        this.nombre = nombre;
    }

    public void Nadar()
    {
        Console.WriteLine($"El animal marino {nombre} está nadando");
    }

}

public class Pulpo : Marino
{
    public Pulpo(string nombre) : base (nombre) { }
    
    public void Camuflarse()
    {
        Console.WriteLine($"El {nombre} se ha camuflado");
    }
}
