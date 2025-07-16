using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class People
{
    public string nombre;
    public int edad;
    public string ciudad;

    public void Presentarse()
    {
        Console.WriteLine($"Hola, soy {nombre}, tengo {edad} años y vivo en {ciudad}");
    }
}