using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Doctor
{
    public string nombre;
    public int edad;

    public Doctor(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    public void Presentarse()
    {
        Console.WriteLine($"Hola, soy el Dr. {nombre}, tengo {edad} años");
    }
}

public class Paciente : Doctor
{
    public Paciente(string nombre, int edad) : base (nombre, edad) { }

    public void Atender()
    {
        Console.WriteLine($"Estoy atendiendo a un paciente");
    }
}