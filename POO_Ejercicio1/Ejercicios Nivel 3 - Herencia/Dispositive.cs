using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dispositive
{
    protected string marca;
    
    public Dispositive(string marca)
    {
        this.marca = marca;
    }

    public void Encender()
    {
        Console.WriteLine($"El dispositivo de marca {marca} está encendido");
    }
}

public class Tablet : Dispositive
{
    public Tablet(string marca) : base(marca) { }

    public void VerVideo()
    {
        Console.WriteLine($"Estás viendo un video en la tablet");
    }
}