using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class JuegoMesa
{
    protected string nombreJuego;
    protected int numeroJugadores;

    public JuegoMesa(string nombreJuego, int numeroJugadores)
    {
        this.nombreJuego = nombreJuego;
        this.numeroJugadores = numeroJugadores;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Juego: {nombreJuego} | Jugadores: {numeroJugadores}");
    }

    public virtual void Instrucciones()
    {
        Console.WriteLine($"Cada juego tiene sus propias reglas");
    }
}

public class Ajedrez : JuegoMesa
{
    public Ajedrez(string nombreJuego, int numeroJugadores) : base(nombreJuego, numeroJugadores) { }

    public override void Instrucciones()
    {
        Console.WriteLine($"Ajedrez: Usa piezas en un tablero de 64 casillas. Gana quien hace jaque mate");
    }
}

public class Uno : JuegoMesa
{
    public Uno(string nombreJuego, int numeroJugadores) : base(nombreJuego, numeroJugadores) { }

    public override void Instrucciones()
    {
        Console.WriteLine("UNO: Elimina tus cartas combinando colores o números. Di 'UNO' con una sola carta.");
    }
}

public class Pictionary : JuegoMesa
{
    public Pictionary(string nombreJuego, int numeroJugadores) : base(nombreJuego, numeroJugadores) { }

    public override void Instrucciones()
    {
        Console.WriteLine("Pictionary: Dibuja palabras sin hablar, tu equipo debe adivinar. ¡Diviértete!");
    }
}