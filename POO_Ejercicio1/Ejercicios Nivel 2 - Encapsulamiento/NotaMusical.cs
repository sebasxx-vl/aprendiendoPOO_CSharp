using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Nota
{
    private string nombreNota;
    private double duracionNota;

    public Nota(string nombreNota, double duracionNota)
    {
        this.nombreNota = nombreNota;
        this.duracionNota = duracionNota;
    }

    public void TocarNota()
    {
        Console.WriteLine($"Tocando nota {nombreNota} durante {duracionNota} segundos");
    }
}