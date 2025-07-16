using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Juego
{
    protected string nombre;

    public Juego(string nombre)
    {
        this.nombre = nombre;
    }

    public void Jugando()
    {
        Console.WriteLine($"Iniciando juego: {nombre}");
    }
}

public class JuegoCartas : Juego
{
    public JuegoCartas(string nombre) : base(nombre) { }

    public void Poker()
    {
        Console.WriteLine($"Las cartas han sido barajadas");
    }
}