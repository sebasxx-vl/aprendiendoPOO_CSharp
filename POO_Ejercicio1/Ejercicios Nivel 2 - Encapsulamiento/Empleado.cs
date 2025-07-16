using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Empleado
{
    private string nombre;
    private string cargo;
    private int salario;

    public Empleado(string nombre, string cargo, int salario)
    {
        this.nombre = nombre;
        this.cargo = cargo;
        this.salario = salario;
    }

    public void MostrarEmpleado()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Cargo: {cargo}");
        Console.WriteLine($"Salario: ${salario}");
        Console.WriteLine();
    }
}