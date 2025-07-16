using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Curso
{
    private string nombreCurso;
    private string docente;
    private int duracionHoras;

    public Curso(string nombreCurso, string docente, int duracionHoras)
    {
        this.nombreCurso = nombreCurso;
        this.docente = docente;
        this.duracionHoras = duracionHoras;
    }

    public void MostrarCurso()
    {
        Console.WriteLine($"Curso: {nombreCurso}");
        Console.WriteLine($"Docente: {docente}");
        Console.WriteLine($"Duración de horas semanales: {duracionHoras}");
        Console.WriteLine();
    }
}