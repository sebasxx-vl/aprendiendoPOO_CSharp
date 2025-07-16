using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Plataforma
{
    protected string usuario;
    protected string serie;

    public Plataforma(string usuario, string serie)
    {
        this.usuario = usuario;
        this.serie = serie;
    }

    public void Estado()
    {
        Console.WriteLine($"Usuario {usuario} conectado.");
    }
}

public class Streaming : Plataforma
{
    public Streaming(string usuario, string serie) : base(usuario, serie) { }

    public void reproducir()
    {
        Console.WriteLine($"Reproduciendo: {serie}");
    }
}