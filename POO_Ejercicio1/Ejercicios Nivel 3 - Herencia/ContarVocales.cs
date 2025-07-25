using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Frase
{
    protected string texto;

    public Frase(string texto)
    {
        this.texto = texto;
    }
    
    public string ObtenerFrase()
    {
        return texto;
    }
}

public class Vocales : Frase
{
    public Vocales(string texto) : base(texto) { }

    public int Contar()
    {
        int contador = 0;
        string vocales = "aeiouAEIOU";

        foreach(char letra in texto)
        {
            if(vocales.Contains(letra))
            {
                contador++;
            }
        }

        return contador;
    }
}