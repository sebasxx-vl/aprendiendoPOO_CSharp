using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dis
{
    protected string marca;
    protected string modelo;

    public Dis(string marca, string modelo)
    {
        this.marca = marca;
        this.modelo = modelo;
    }

    public void Datos()
    {
        Console.WriteLine($"Dispositivo {marca} {modelo} encendido");
    }
}

public class Smartwatch : Dis
{
    public Smartwatch(string marca, string modelo) : base(marca, modelo) { }

    public void Pasos()
    {
        Console.WriteLine($"Has dado 3,500 pasos hoy");
    }
}