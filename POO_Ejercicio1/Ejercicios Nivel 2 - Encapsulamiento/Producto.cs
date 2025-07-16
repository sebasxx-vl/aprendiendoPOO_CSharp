using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Producto
{
    private string nombre;
    private double precio;
    private string categoria;

    public Producto(string nombre, double precio, string categoria)
    {
        this.nombre = nombre;
        this.precio = precio;
        this.categoria = categoria;
    }
    public void MostrarDatos()
    {
        Console.WriteLine($"Producto: {nombre}");
        Console.WriteLine($"Precio: {precio}");
        Console.WriteLine($"Categoria: {categoria}");
        Console.WriteLine();
    }
}