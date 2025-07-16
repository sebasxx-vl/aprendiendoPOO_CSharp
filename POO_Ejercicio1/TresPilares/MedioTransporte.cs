using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Transporte
{
    protected int velocidadMaxima;
    protected string tipo;

    public Transporte(int velocidadMaxima, string tipo)
    {
        this.velocidadMaxima = velocidadMaxima;
        this.tipo = tipo;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Tipo: {tipo}, Velocidad Máxima: {velocidadMaxima} km/h");
    }
}

public class Tren : Transporte
{
    public Tren(int velocidadMaxima, string tipo) : base (velocidadMaxima, tipo) { }

    public void IniciarRecorrido()
    {
        Console.WriteLine("El tren ha iniciado su recorrido");
    }
}