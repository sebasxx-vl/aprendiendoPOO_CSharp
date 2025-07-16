using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Libro()
{
    public string Titulo;
    public string Autor;
    public int yearPublic;

    public void InfoLibro()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Año de publicación: {yearPublic}");
        Console.WriteLine();
    }
}