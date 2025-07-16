using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Persona
{
    private string nombre;
    private int edad;

    public Persona(string n, int e)
    {
        nombre = n;
        edad = e;
    }   

    public void Mostrar()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine();
    }
}