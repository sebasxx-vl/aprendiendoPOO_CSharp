using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Telar
{
    private int ejecucionesMaximas;

    public Telar(int totalEjecuciones)
    {
        this.ejecucionesMaximas = totalEjecuciones;
    }

    public void EjecutarProceso()
    { 
        for(int ejecucion = 1; ejecucion <= ejecucionesMaximas; ejecucion++)
        {
            Console.WriteLine($"Iniciando ejecucion #{ejecucion}");

            for(int contador = 1; contador <= 500; contador++)
            {
                if(contador % 100 == 0)
                {
                    Console.WriteLine($"Contador: {contador}");
                }
            }

            Console.WriteLine($"Ejecucion #{ejecucion} completada");
            Console.WriteLine();
        }

        Console.WriteLine("Todas las ejecuciones han terminado");
    }
}