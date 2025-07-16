using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pelicula
{
    public string titulo;
    public string genero;
    public int duracion;

    public void MostrarPelicula()
    {
        Console.WriteLine($"Pelicula: {titulo}");
        Console.WriteLine($"Género: {genero}");
        Console.WriteLine($"Duracion: {duracion} min");
    }
}