using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Celular
{
    public string marca;
    public string modelo;

    public void Llamar()
    {
        Console.WriteLine($"Llamando desde un {marca} {modelo}");
    }
}