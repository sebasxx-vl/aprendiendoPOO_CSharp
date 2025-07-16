using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Usuario
{
    protected string nombre;
    protected string correo;

    public Usuario(string nombre, string correo)
    {
        this.nombre = nombre;
        this.correo = correo;
    }

    public void DatosPersonales()
    {
        Console.WriteLine($"Usuario: {nombre}");
        Console.WriteLine($"Correo: {correo}");

    }
}

public class ReservaHotel : Usuario
{
    private int noches;
    private double precioNoche;
    private double IVA;
    private double Total;

    public ReservaHotel(string nombre, string correo, int noches, double precioNoche, double iVA) : base(nombre, correo) 
    {
        this.noches = noches;
        this.precioNoche = precioNoche;
        this.IVA = iVA;
    }

    public void Reserva()
    {
        Console.WriteLine($"Reserva {noches} noches a ${precioNoche.ToString("0.000")}");
        double subtotal = precioNoche * noches;
        Total = subtotal + (subtotal * IVA);
        Console.WriteLine($"Total con IVA: {Total.ToString("0.0000")}");
    }
}