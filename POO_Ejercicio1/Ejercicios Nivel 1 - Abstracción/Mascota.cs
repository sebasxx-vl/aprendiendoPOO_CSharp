using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mascota
{
    public string nombre;
    public string tipo;

    public void Presentarse()
    {
        Console.WriteLine($"Soy un {tipo} llamado {nombre}");
    }
}