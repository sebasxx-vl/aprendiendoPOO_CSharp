using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void EvaluarEdad()
    {
        if (age >= 18)
            Console.WriteLine($"{name} si es mayor de edad");
        else
        {
            Console.WriteLine($"{name} es menor de edad");
        }
    }
}