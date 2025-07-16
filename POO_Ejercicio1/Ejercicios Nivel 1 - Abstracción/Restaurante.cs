using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Restaurante
{
    public string nombre;
    public string tipoComida;
    public string ciudad;

    public void Info()
    {
        Console.WriteLine($"Restaurante {nombre}, especializado en comida {tipoComida}, ubicado en {ciudad}");
    }
}