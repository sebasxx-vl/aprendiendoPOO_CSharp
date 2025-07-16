using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Carro
{
    public string marca;
    public string modelo;
    public int year;


    
    public void Arrancar()
    {
        Console.WriteLine($"El {marca} {modelo} está arrancando");
    }
}