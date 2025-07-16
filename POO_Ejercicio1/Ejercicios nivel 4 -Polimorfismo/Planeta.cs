using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Planeta
{
    protected string nombre;

    public Planeta(string nombre)
    {
        this.nombre = nombre;
    }
    public virtual string ObtenerDescripcion()
    {
        return "Este es un planeta del sistema solar";
    }
}

public class Mercurio : Planeta
{
    public Mercurio() : base("Mercurio") { }

    public override string ObtenerDescripcion()
    {
        return $"{nombre} es el planeta más cercano al sol";
    }
}

public class Saturno : Planeta
{
    public Saturno() : base("Saturno") { }

    public override string ObtenerDescripcion()
    {
        return $"{nombre} es famoso por sus anillos impresionantes";
    }
}   

public class Neptuno : Planeta
{
    public Neptuno() : base("Neptuno") { }

    public override string ObtenerDescripcion()
    {
        return $"{nombre} es un gigante gaseoso muy lejano";
    }
}
