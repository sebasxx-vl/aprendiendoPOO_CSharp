using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Archivo
{
    protected double pesoMB;

    public Archivo(double pesoMB) 
    { 
        this.pesoMB = pesoMB;
    }

    public void apertura()
    {
        Console.WriteLine($"Abriendo archivo PDF ({pesoMB} MB)...");
    }
}

public class ArchivoPDF : Archivo
{
    public ArchivoPDF(double pesoMB) : base(pesoMB) { }
    public void Buscar()
    {
        Console.WriteLine($"Palabra encontrada: 'Contrato'");
    }
}