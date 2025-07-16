using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public class Vehiculo
{
    private string modelo;
    private string marca;
    private int year;

    public Vehiculo(string modelo, string marca, int year)
    {
        this.modelo = modelo;
        this.marca = marca;
        this.year = year;
    }

    public void MostrarVehiculo()
    {
        Console.WriteLine($"Automovil ultimo modelo: {modelo}");
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Año: {year}");
        Console.WriteLine();
    }
}