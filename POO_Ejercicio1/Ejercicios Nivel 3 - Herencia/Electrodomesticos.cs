using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Electrodomestico
{
    protected string marca;

    public Electrodomestico(string marca)
    {
        this.marca = marca;
    }

    public void Encender()
    {
        Console.WriteLine($"El electrodoméstico {marca} está encendido");
    }
}

public class Lavadora : Electrodomestico
{
    public Lavadora(string marca) : base(marca) { }
    public void LavarRopa()
    {
        Console.WriteLine($"La lavadora {marca} está lavando ropa");
    }
}

public class Refrigerador : Electrodomestico
{
    public Refrigerador(string marca) : base(marca) {}
    public void Enfriar()
    {
        Console.WriteLine($"El refrigerador {marca} está enfriando.");
    }
}