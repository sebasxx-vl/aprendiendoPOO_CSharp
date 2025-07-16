using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tarea
{
    private string descripcion;
    private bool completada;

    public Tarea(string descripcion, bool completada)
    {
        this.descripcion = descripcion;
        this.completada = completada;
    }

    public void MostrarEstado()
    {
        Console.WriteLine($"Tarea: {descripcion}");

        if(completada)
        {
            Console.WriteLine("✔️ Completada");
        }
        else
        {
            Console.WriteLine("❌ Pendiente");
        }
        Console.WriteLine();
    }
}