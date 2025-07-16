using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Estudiante
{
    private string nombre;
    private string carrera;
    private double[] notas;

    public Estudiante(string nombre, string carrera, double[] notas)
    {
        this.nombre = nombre;
        this.carrera = carrera;
        this.notas = notas;
    }
    
    public void MostrarPromedio()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Carrera: {carrera}");

        double suma = 0;
        foreach (double nota in notas)
        {
            suma += nota;
        }

        double promedio = suma / notas.Length;

        Console.WriteLine($"Promedio: {promedio}");
        Console.WriteLine();
    }
 }