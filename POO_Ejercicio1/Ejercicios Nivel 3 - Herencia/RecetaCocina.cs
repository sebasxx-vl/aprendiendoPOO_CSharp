using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Receta
{
    protected string nombre;
    protected int tiempo;

    public Receta(string nombre, int tiempo)
    {
        this.nombre = nombre;
        this.tiempo = tiempo;
    }

    public string ObtenerResumen()
    {
        return $"Receta: {nombre} - Tiempo : {tiempo} minutos";
    }
}

public class RecetaVegetariana : Receta
{
    protected string vegetalPrincipal;
    public  RecetaVegetariana (string nombre, int tiempo, string vegetal) : base (nombre , tiempo) 
    {
        this.vegetalPrincipal = vegetal;
    }

    public string ObtenerIngredientes()
    {
        return $"Ingredientes base: {vegetalPrincipal}, especias, sal y aceite de oliva.";
    }
}
