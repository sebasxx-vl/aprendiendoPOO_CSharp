using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Produc
{
    protected string nombre;
    protected string origen;
    protected double precioBase;

    public Produc(string nombre, string origen, double precioBase)
    {
        this.nombre = nombre;
        this.origen = origen;
        this.precioBase = precioBase;
    }

    public void MostrarDetalle()
    {
        Console.WriteLine($"Producto: {nombre}");
        Console.WriteLine($"Origen: {origen}");
        Console.WriteLine($"Precio base: ${precioBase.ToString("0.000")}");
    }
}

public class Importado : Produc
{
    private double impuesto;
    private double precioFinal;
    public Importado(string nombre, string origen, double precioBase, double impuesto) : base(nombre, origen, precioBase)
    {
        this.impuesto = impuesto;
    }

    public void Aduanas()
    {
        precioFinal = precioBase + impuesto;
        Console.WriteLine($"Impuesto de aduana: ${impuesto.ToString("0.000")}");
        Console.WriteLine($"Precio Final: ${precioFinal.ToString("0.000")}");
    }
}