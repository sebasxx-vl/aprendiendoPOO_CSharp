using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Numero
{
    protected int numero;

    public Numero(int numero)
    {   
        this.numero = numero; 
    }
}

public class Multiplo : Numero
{
    public Multiplo(int numero) : base(numero) { }

    public int ObtenerNumero()
    {
        return numero;
    }

    public string Revisar()
    {
        if (numero % 3 == 0 && numero % 5 == 0)
        {
            return "Es múltiplo de ambos";
        }
        else if (numero % 3 == 0)
        {
            return "Es múltiplo de 3";
        }
        else if (numero % 5 == 0)
        {
            return "Es múltiplo de 5";
        }
        else
        {
            return "No es múltiplo de ninguno";
        }
    }
}