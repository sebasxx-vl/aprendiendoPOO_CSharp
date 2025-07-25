using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Num
{
    protected int valor;

    public Num(int valor)
    {
        this.valor = valor;
    }
}


public class Digitos : Num
{
    public Digitos(int valor) : base(valor) { }

    public int Contar()
    {
        string texto = valor.ToString();
        return texto.Length;
    }
}