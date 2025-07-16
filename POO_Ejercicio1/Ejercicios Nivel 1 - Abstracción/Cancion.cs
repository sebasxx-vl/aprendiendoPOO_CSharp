using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cancion
{
    public string titulo;
    public string artista;
    public int duracion;

    public void Reproducir()
    {
        Console.WriteLine($"Reproduciendo: {titulo} de {artista}");
    }
}