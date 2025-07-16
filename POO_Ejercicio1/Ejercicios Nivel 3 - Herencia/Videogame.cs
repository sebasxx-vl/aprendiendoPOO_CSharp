using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Game //Clase padre
{
    protected string name;//Atributo
                            
    public Game(string name) //Constructor
    {
        this.name = name;
    }

    public void Play() //Método de la clase padre
    {
        Console.WriteLine($"You are playing {name}");
    }
}

public class VideoGame : Game //Clase hija que hereda de Game
{
    public VideoGame(string name) : base(name) { } //Constructor que llama al constructor de la clase padre

    public void SaveGame() //Método exclusivo de la clase hija
    {
        Console.WriteLine($"Game of {name} saved successfully");
    }

}