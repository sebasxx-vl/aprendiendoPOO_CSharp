using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public class Estacion
{
    protected string nombreEstacion;

    public Estacion(string nombreEstacion)
    {
        this.nombreEstacion = nombreEstacion;
    }

    public virtual string ClimaActual()
    {
        return $"Clima general no especificado";
    }
}

public class Tropical : Estacion
{
    public Tropical() : base("Tropical") { }

    public override string ClimaActual()
    {
        return $"El clima {nombreEstacion} suele llover con alta humedad";
    }
}

public class Templada : Estacion
{
    public Templada() : base("Templado") { }
    
    public override string ClimaActual()
    {
        return $"En clima {nombreEstacion} hay estaciones definindas";
    }

}

public class Desertica : Estacion
{
    public Desertica() : base("Desertico") { }

    public override string ClimaActual()
    {
        return $"E clima {nombreEstacion} hay altas temperaturas y poca lluvia";
    }
}

