using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dispositivo //FUNCION / CLASE
{
    protected string marca; //ATRIBUTO1
    protected string modelo; //ATRIBUTO2

    public Dispositivo(string marca, string modelo) //CONSTRUCTOR
    {
        this.marca = marca;
        this.modelo = modelo;
    }

    public void Encender() // Metodo
    {
        Console.WriteLine($"{marca} {modelo} está encendido");
    }
}

public class Celu : Dispositivo
{
    public Celu (string marca, string modelo) : base(marca, modelo) { }

    public void Llamar()
    {
        Console.WriteLine($"Llamando desde el celular {marca} {modelo}");
    }
}