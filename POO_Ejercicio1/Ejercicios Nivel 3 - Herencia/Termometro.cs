using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Sensor
{
    protected double valorMedido;

    public Sensor(double valorMedido)
    {
        this.valorMedido = valorMedido;
    }

    public string TemperaturaActual()
    {
        return $"Temperatura actual: {valorMedido.ToString("00.0")}ºC";
    }
}

public class Temperatura : Sensor
{
    public Temperatura(double valorMedido) : base(valorMedido){ }
    
    public string rango()
    {
        if (valorMedido >= 36.0 && valorMedido <= 37.5)
        {
            return $"Estado: Temperatura saludable";
        }
        else if(valorMedido > 37.5)
        {
            return $"Estado: Temperaturas altas";
        } else
        {
            return $"Estado: Temperaturas bajas";
        }
    }
}