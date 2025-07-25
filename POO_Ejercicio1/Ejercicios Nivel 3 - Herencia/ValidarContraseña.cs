using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Alguien
{
    protected string clave;

    public Alguien(string clave)
    {
        this.clave = clave;
    }
}

public class ClaveSegura : Alguien 
{
    public ClaveSegura(string clave) : base(clave) { }

    public string ObtenerClave()
    {
        return clave;
    }

    public string validarClave()
    {
        if(clave.Length >= 8)
        {
            return "Contraseña valida";
        }
        else
        {
            return "Contraseña demasiado corta";
        }
    }
}