using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public class Iva
{
    private string nombre;
    private double precioBase;
    private double iva = 0.19;
    private double total;

    public Iva(string nombre, double precioBase)
    {
        this.nombre = nombre;
        this.precioBase = precioBase;
    }

    public void MostrarPrecioIva()
    {
        total = precioBase + (precioBase * iva);
        Console.WriteLine($"El producto {nombre}, cuesta {precioBase.ToString("0.000")}, con IVA = {total.ToString("")}");
        Console.WriteLine();
    }
}